using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMAnager : MonoBehaviour
{

    public GameObject Menu;
    private bool _canOpen;
    private Pause _pause;


    private void Start()
    {
        _pause = GetComponent<Pause>();
    }

    void Update()
    {
        MenuPanel();
    }

    public void MenuPanel()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _canOpen = !_canOpen;

            if(_canOpen)
            {

                Menu.SetActive(true);
                _pause.PauseTrue();
            }
            else
            {
                Menu.SetActive(false);
                _pause.PauseFalse();

            }
        }
    }
}
