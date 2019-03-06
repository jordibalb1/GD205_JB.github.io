using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float movementSpeed;
    public float rotationSpeed;
    public float rotX;
    public float rotY;
    public float rotZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift)&& Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        } else if (Input.GetKey("w")&& !Input.GetKey(KeyCode.LeftShift))
        {
            transform
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
