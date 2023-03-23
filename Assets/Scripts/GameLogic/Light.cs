using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public float StartLight; 
    public float EndtLight;
    public GameObject[] Lights;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Lights.Length; i++)
        {

            if (StartLight <= 0)
            {

                Lights[i].gameObject.SetActive(false);

                StartLight = EndtLight;

            }
            else
            {
                Lights[i].gameObject.SetActive(true);
                StartLight -= Time.deltaTime;
            }
        }
        }
    }
