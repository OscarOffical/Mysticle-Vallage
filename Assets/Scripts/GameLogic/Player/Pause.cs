using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Pause : MonoBehaviour
{
    private PlayerControler playerControler;
    public RotitionHand1 RotitionHand;
    

    private void Start()
    {
        playerControler = GetComponent<PlayerControler>();
        
    }

    public void PauseTrue()
    {
        playerControler.enabled = false;
        Time.timeScale = 0;
        RotitionHand.enabled = false;
    }

    public void PauseFalse()
    {
        playerControler.enabled = true;
        Time.timeScale = 1;
        RotitionHand.enabled = true;
    }
}
