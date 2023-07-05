using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    private int numberOfTimes = 7;
    public float theSpeedOf = 6.90f;
    private string theNameOf = "Cam";

    string theArrowToPress = "right";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi, " + theNameOf + ", press the " + theArrowToPress +  " key " + numberOfTimes + " times to go right at the speed of " + theSpeedOf );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
