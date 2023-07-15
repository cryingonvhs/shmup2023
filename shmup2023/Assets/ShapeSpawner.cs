using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{


    public Shape[] shapePrefabs;
    

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("Hi, " + theNameOf + ", press the " + theArrowToPress +  " key " + numberOfTimes + " times to go right at the speed of " + theSpeedOf );
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < shapePrefabs.Length; i++) 
            {
                Instantiate(shapePrefabs[i]);

            }

            
            {

            }



            }
        }
    }

