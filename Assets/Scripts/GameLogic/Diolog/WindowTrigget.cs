using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowTrigget : MonoBehaviour
{
    public GameObject WhatWinsowOpen;
    public AllWeapen allWeapen;
    public GameObject Player;
 
    


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
              
                WhatWinsowOpen.SetActive(true);
                Player.GetComponent<KeyboardMAnager>().enabled = false;
                Player.GetComponent<PlayerControler>().enabled = false;     
               
                Player.GetComponent<Pause>().PauseTrue();

                
                Destroy(gameObject);
             

            }
        }
    }
}

