using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 15.0f;
    private float rotationSpeed = 3000.0f;
    private float verticalInput;
    private float tiltSpeed = 300.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame whats the difference between Update and FixedUpdate
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // did a google search for referencing child objects in UNity ... i will not need a new script to control the propeller
        GameObject.Find("Propeller").transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * tiltSpeed * Time.deltaTime * verticalInput);
    }
}
