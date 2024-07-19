using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCrtl : MonoBehaviour
{
    // Start is called before the first frame update
    public Light myLightV1;
    public Light myLightV2;
    public float Speed;
    public float Speed2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myLightV1.intensity = Mathf.Sin(Time.time * Speed) * 10;
        myLightV2.intensity = Mathf.Abs(Mathf.Sin(Time.time * Speed2) * 10);

        if (Input.GetKeyDown(KeyCode.E))
        {
            myLightV1.enabled = !myLightV1.enabled;

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            myLightV2.enabled = !myLightV2.enabled;

        }
    }
}