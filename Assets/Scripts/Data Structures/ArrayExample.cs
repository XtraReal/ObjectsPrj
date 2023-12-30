using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    public GameObject testPrefab;
    public GameObject[] array;
    public GameObject[] initializedArray = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        GenerateArrayIndex(0);
        GenerateArrayIndex(1);
        GenerateArrayIndex(2);

    }

    public void GenerateArrayIndex(int index)
    {
        initializedArray[index] = Instantiate(testPrefab, transform); 
        initializedArray[index].transform.position = new Vector2(index,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log($"The Length of Array is {initializedArray.Length}");
        }
        if(Input.GetKeyUp(KeyCode.W))
        {
            foreach(var item in initializedArray)
            {
                item.GetComponent<SpriteRenderer>().color = Color.white;
            }
            initializedArray[Random.Range(0, initializedArray.Length)].GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
