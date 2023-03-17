using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyboardInputSetting : MonoBehaviour
{
    [SerializeField] private GameObject _Placeholder;
    [SerializeField] private GameObject Text;
    public TMP_Text text; 


    void Start()
    {
        _Placeholder= transform.GetChild(0).GetChild(1).gameObject;
        Text = transform.GetChild(0).GetChild(2).gameObject;
    }

   

    public void Input()
    {
        _Placeholder.gameObject.SetActive(false);
       
    }

    public void Enter()
    {
        _Placeholder.gameObject.SetActive(true);
         text.text = Text.GetComponent<TextMeshPro>().text;
        _Placeholder.GetComponent<TextMeshPro>().text = text.text;
        Debug.Log(text.text);
        
    }
}
