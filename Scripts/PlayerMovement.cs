using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float _forwardForce;
    public float _sideways;
    // Start is called before the first frame update
   

    // we r using fixed update because
    // we r going to mess with physics
    void FixedUpdate()
    {// Add a Forward Force
        rb.AddForce(0, 0, _forwardForce*Time.deltaTime);

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(_sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey(KeyCode.A)) 
        {
              rb.AddForce(-_sideways * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().Gameover();

        }
    }
}