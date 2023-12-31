using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DictionaryExample : MonoBehaviour
{
    [SerializeField] private TMP_Text txtTriangle, txtSquare, txtCircle;

    public Dictionary<string, int> myDict = new Dictionary<string, int>();

    // Start is called before the first frame update
    void Start()
    {
        myDict.Add("Triangles", 0);
        myDict.Add("Squares", 0);
        myDict.Add("Circles", 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Add Triangles
        if (Input.GetKeyUp(KeyCode.Q))
        {
            if (myDict.ContainsKey("Triangles"))
            {
                myDict["Triangles"]++;
                txtTriangle.text = myDict["Triangles"].ToString();
            }
        }
        
        // Add Squares
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (myDict.ContainsKey("Squares"))
            {
                myDict["Squares"]++;
                txtSquare.text = myDict["Squares"].ToString();
            }
        }
        
        // Add Circles
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (myDict.ContainsKey("Circles"))
            {
                myDict["Circles"]++;
                txtCircle.text = myDict["Circles"].ToString();
            }
        }
    }
}
