using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using Unity.VisualScripting;

public class CanDragFont : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    TMP_Text _Text;

    private void Start()
    {
        _Text = transform.GetChild(0).GetComponent<TMP_Text>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _Text.color = new Color(255, 176, 0, 255);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _Text.color = new Color(255, 255, 255, 255);
    }


}
