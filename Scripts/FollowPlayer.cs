using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform Player;
    public Vector3 _offset;

    // Update is called once per frame
    void Update()
    {
        /*print(Player.position);*/
        transform.position = Player.position + _offset;
    }
}
