using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] public GameObject[] Window; 
 
    public void NewGame()
    {
        
        for (int i = 0; i < Window.Length; i++)
        {
           
            if (Window[0] != Window[i])
            {
                 Window[i].SetActive(false);
            }
            else
            {
                Window[0].SetActive(true);
            }
           
        }
       
    }
    public void ContiueGame()
    {
        for (int i = 0; i < Window.Length; i++)
        {

            if (Window[2] != Window[i])
            {
                Window[i].SetActive(false);
            }
            else
            {
                Window[2].SetActive(true);
            }

        }
    }
    public void Setting()
    {
        for (int i = 0; i < Window.Length; i++)
        {

            if (Window[3] != Window[i])
            {
                Window[i].SetActive(false);
            }
            else
            {
                Window[3].SetActive(true);
            }

        }
    }
    public void Exit()
    {
        for (int i = 0; i < Window.Length; i++)
        {

            if (Window[1] != Window[i])
            {
                Window[i].SetActive(false);
            }
            else
            {
                Window[1].SetActive(true);
            }

        }
    }

}
