using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Shape : MonoBehaviour
{
    float forceMagnitude = 5f;


    Material shapeMaterial;
    Rigidbody myRigidbody;
   
   
    

    // Start is called before the first frame update
    void Start()
    {
        shapeMaterial = GetComponent<MeshRenderer>().material;
        myRigidbody = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        { myRigidbody.AddForce(Vector3.left * forceMagnitude);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(Vector3.right * forceMagnitude);

        }
        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddForce(Vector3.forward * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myRigidbody.AddForce(Vector3.back * forceMagnitude);
        }
       
    
    
    
            if (transform.position.y < 3)
        {
            shapeMaterial.color = Color.green;


        }
        if (transform.position.x < -2)
            shapeMaterial.color = Color.red;

        else if (transform.position.x > 2)
        {
            shapeMaterial.color = Color.blue; 
        }
    

    

    }
}
