using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UIElements;

public class Trigger : MonoBehaviour
{
    public DiologManager diologManager;
    public int NumberDiolog;
    public bool canAnimation = false;
    public GameObject car;
    
   
    

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                diologManager.Diolog(NumberDiolog);
                if(canAnimation == true)
                {
                    car.GetComponent<Animation>().Play("Car Animation");

                }
                Destroy(gameObject);

            }
        }
    }
    
}




