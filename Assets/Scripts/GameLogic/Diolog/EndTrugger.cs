using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EndTrugger : MonoBehaviour
{
    public GameObject Panel;
    bool CanNext= false;
    public float StartNextLevel;
    public KeyboardMAnager keyboardMAnager;

    private void Update()
    {
        NextLevel();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                keyboardMAnager.enabled = false;
                Panel.SetActive(true);
                CanNext = true;


            }
        }
    }
    public void NextLevel()
    {
        if(CanNext == true)
        {
            if(StartNextLevel <=0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                StartNextLevel -= Time.deltaTime;
            }
        }
    }

}




