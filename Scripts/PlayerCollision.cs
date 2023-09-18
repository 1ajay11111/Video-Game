using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager manager;

    void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.tag == "Enemy")
        {
            print(collision.collider.name);
            GetComponent<PlayerMovement>().enabled = false;
            /* manager.Gameover();*/
            manager.Gameover();

        }
    }
}
