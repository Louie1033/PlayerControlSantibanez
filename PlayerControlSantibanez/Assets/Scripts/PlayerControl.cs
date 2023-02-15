using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 12.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //this will move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //this controlls the steering of the car
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
