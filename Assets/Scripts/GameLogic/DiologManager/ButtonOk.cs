using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOk : MonoBehaviour
{
    public GameObject WhatDestroy;
    public GameObject Player;
    public GameObject Animation;
    
    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Ok()
    {
        Player.SetActive(true);
        Animation.SetActive(true);
        Destroy(WhatDestroy);
       

    }
}
