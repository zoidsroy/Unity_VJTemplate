using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField] public float rotateSpeed=3;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        obj = this.gameObject;   
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Rotate(0,Time.time*Time.deltaTime,0);
    }
}
