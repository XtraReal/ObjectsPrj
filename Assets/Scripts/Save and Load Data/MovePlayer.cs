using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    float horizontalInput, verticalInput;
    float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        Vector3 movDir = new Vector3(horizontalInput, 0, verticalInput);

        transform.Translate(movDir * speed * Time.deltaTime); 
    }
}
