using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
    public GameObject WinPanel;

     void Start()
    {
        WinPanel.SetActive(false);
    }


    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            WinPanel.SetActive(true);
        }
    }

}


