using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowExit : MonoBehaviour
{
    public GameObject WhatWinsowOpen;
    public AllWeapen allWeapen;
    public GameObject Player;


    public void Exit()
    {
        WhatWinsowOpen.SetActive(false);
        Player.GetComponent<KeyboardMAnager>().enabled = true;
        Player.GetComponent<PlayerControler>().enabled = true;
        allWeapen.Lantern = true;
        Player.GetComponent<Pause>().PauseFalse();
        Destroy(WhatWinsowOpen);
    }
}
