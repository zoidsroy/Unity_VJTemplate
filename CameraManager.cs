using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
     private GameObject[] _VCams;
    [SerializeField] GameObject mainCam;

    void Start()
    {
        GameObject camManager = this.gameObject;

        _VCams = new GameObject[camManager.transform.childCount];
        for (int i=0;i<camManager.transform.childCount;i++)
        {
          _VCams[i]=  camManager.transform.GetChild(i).gameObject;
        }

        for (int i=1;i<_VCams.Length;i++)
        {
            _VCams[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < _VCams.Length; i++)
            {
                _VCams[i].SetActive(false);
            }
            _VCams[Random.Range(0, _VCams.Length)].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i=0;i<_VCams.Length;i++) {
                print(_VCams[i].name);
            }
            
        }
    }
}
