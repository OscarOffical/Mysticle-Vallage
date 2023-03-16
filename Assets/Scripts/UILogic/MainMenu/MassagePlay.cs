using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MassagePlay : MonoBehaviour
{
    [SerializeField]private GameObject _battonYse; 
    [SerializeField]private GameObject _battonNo;
    
    void Start()
    {
        _battonYse = transform.parent.gameObject;
        _battonNo = transform.parent.gameObject;
    }

    public void IKnowYse()
    {
        SceneManager.LoadScene(1);
    }

    public void IKnowNo()
    {
        transform.parent.gameObject.SetActive(false);
    }
}
