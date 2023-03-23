using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigget : MonoBehaviour
{
    public GameObject WhatWinsowOpen;
    public GameObject Player;
    public GameObject Animation;
    public AllWeapen allWeapen;

    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                
                WhatWinsowOpen.SetActive(true);
                allWeapen.Lantern = true;
                Player.SetActive(false);
                Animation.SetActive(false);
                Destroy(gameObject);
             

            }
        }
    }
}

