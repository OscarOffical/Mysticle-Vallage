using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiologManager : MonoBehaviour
{
    public string[] diologi;
    public TMP_Text TextPlayer;
    int g;
    public float second;

    public float StartTimeDestroyText;
    private float EndTimeDestroyText;
    public bool CanDeleta = false;

    private void Start()
    {
        EndTimeDestroyText = StartTimeDestroyText;
    }
    private void Update()
    {
        destoryText();
    }
    public void Diolog(int i)
    {
        g = i;
        StartCoroutine(TextCorytion());
        
       


    }

    IEnumerator TextCorytion()
    {
        foreach (char abc in diologi[g])
        {
            TextPlayer.text += abc;
            yield return new WaitForSeconds(second);
        }

        CanDeleta = true;


    }

    public void destoryText()
    {
        if (CanDeleta == true)
        {
            if (StartTimeDestroyText <= 0)
            {
                TextPlayer.text = "";
                StartTimeDestroyText = EndTimeDestroyText;
                CanDeleta = false;


            }
            else
            {
                StartTimeDestroyText -= Time.deltaTime;
            }
            
        }
        
    }
    


}
