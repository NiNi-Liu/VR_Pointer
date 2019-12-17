using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;


public class button_Transition : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler,IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
{
    public Color32 m_normal = Color.white;
    public Color32 m_hover = Color.grey;
    public Color32 m_down = Color.white;
    public UnityEvent button_pinch;


    private Image m_image;

    private void Awake()
    {
        m_image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("enter");

        m_image.color = m_hover;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("Exit");

        m_image.color = m_normal;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        print("Down");

        m_image.color = m_down;
        button_pinch.Invoke();


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        print("Up");
        m_image.color = m_normal;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        print("Click");

        m_image.color = m_normal;
    }
}
