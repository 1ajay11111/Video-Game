using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text Scoretext;
    
    // Update is called once per frame
    void Update()
    {
      Scoretext.text = Player.position.z.ToString("0"); 
    }
}
