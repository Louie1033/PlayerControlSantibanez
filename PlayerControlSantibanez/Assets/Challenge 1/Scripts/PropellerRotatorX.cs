using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotatorX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, 45);
    }
}
