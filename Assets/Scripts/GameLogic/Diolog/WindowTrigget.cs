using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigget : MonoBehaviour
{
    public GameObject WhatWinsowOpen;
    public GameObject Animation;
    public AllWeapen allWeapen;
    public Pause pause;

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                pause.PauseTrue();
                WhatWinsowOpen.SetActive(true);
                allWeapen.Lantern = true;         
                Animation.SetActive(false);
                Destroy(gameObject);
             

            }
        }
    }
}

