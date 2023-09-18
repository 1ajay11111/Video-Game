using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   bool gameHasEnded = false;
    public void Gameover()

    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("gameover");
            Invoke("Restart", 1f);
        }

    }
       
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}

