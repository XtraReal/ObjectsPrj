using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyArray : MonoBehaviour
{
    public GameObject[] Array = new GameObject[6];
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Instantiate(prefab, transform);
            Array[i].transform.position = new Vector2(i, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            return;
        }
    }
}
