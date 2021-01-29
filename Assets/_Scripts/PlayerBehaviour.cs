using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame (runs once every 16.6666 ms)
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // move to the right
            rigidBody.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            // move to the left
            rigidBody.AddForce(Vector3.left * movementForce);
        }
    }
}
