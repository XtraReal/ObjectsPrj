using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjectTest", menuName = "SMS, Create Scriptable Object", order = 1)] // Marks scriptable object and allows us to create an instance of our scriptable object
public class ScriptableObjectSample : ScriptableObject
{
    public string objectName;
    public int score;
    public Vector2 startPosition;
}
