using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource CarAudioSours;
    public AudioClip CarAudioClip;
    public float TimeDeleteObject;
    public bool CanDelete;

    
    private void Update()
    {
        Delete();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                CarAudioSours.PlayOneShot(CarAudioClip);
                CanDelete = true;



            }
        }
    }

    public void Delete()
    {
        if (CanDelete == true)
        {
            if (TimeDeleteObject <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                TimeDeleteObject -= Time.deltaTime;
            }
        }
       
    }

}

