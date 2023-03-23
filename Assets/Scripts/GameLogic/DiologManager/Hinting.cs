using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinting : MonoBehaviour
{
    public bool IsTrue;
    public GameObject Panel;
    public GameObject Player;
    public GameObject Animation;
    private void Awake()
    {

        Player = GameObject.FindGameObjectWithTag("Player");


        Panel.SetActive(IsTrue);
        Player.SetActive(!IsTrue);
        Animation.SetActive(!IsTrue);
    }

    

   
}
