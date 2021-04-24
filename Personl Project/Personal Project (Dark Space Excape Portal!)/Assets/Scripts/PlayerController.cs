using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Access Modifier, Data Type, Name
    private float speed = 30.0f;
    private float turnSpeed = 35.0f;
    private float zBound = 60;
    public float xRange = 60;

    private float hInput;
    private float fInput;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Gathers the inputs for the controls
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * fInput);  // Makes the Player go forward and back

        transform.Rotate(Vector3.up, turnSpeed * hInput * Time.deltaTime); // Makes the Player go left and right

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);  // Made constraints on the edge of map barrier on the top of the map
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);  // Made constraints on the edge of map barrier on the bottom of the map
        }

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z); // Made constraints on the edge of map barrier on x axis
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z); // Made constraints on the edge of map barrier on x axis
        }

    }
}
