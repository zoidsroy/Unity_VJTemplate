using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floatingMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    [SerializeField] private float speed;
    [SerializeField] private float amp;
    private Vector3 originPos;
    void Start()
    {
        obj = this.gameObject;
        originPos = obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = originPos + new Vector3(0,Mathf.Sin(Time.time*speed)*amp,0);
    }
}
