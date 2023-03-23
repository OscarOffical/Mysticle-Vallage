using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour
{
    private AllWeapen allWeapen;
    public bool Open;
    public GameObject Lantern;
    // Start is called before the first frame update
    void Start()
    {
        allWeapen = FindObjectOfType<AllWeapen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            
            if (allWeapen.Lantern == true)
            {
                Open = !Open;
                if (Open)
                {
                    Lantern.SetActive(true);
                }
                else
                {
                    Lantern.SetActive(false);
                }
            }
            else
            {
                return;
            }
            
            
        }

        
    }
}
