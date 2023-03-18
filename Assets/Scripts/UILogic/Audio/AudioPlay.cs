using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AudioPlay : MonoBehaviour
{
    public AudioSource Manager;
    public AudioClip PlauClip;
   

  public void PlayClipManager()
   {
        Manager.PlayOneShot(PlauClip);
   }
    
}
