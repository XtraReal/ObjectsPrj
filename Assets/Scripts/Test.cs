using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Utilities.ShowDeviceID("LUCY");
        Debug.Log(Utilities.DEVICE_ID);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
