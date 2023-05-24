using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggginganddropping : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //public GameObject chestslot;
    public Image image;
     [HideInInspector] public Transform parentAfterDrag;

    [SerializeField]
    private GraphicRaycaster raycaster;
    private PointerEventData m_PointerEventData;
    private EventSystem m_EventSystem;

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        //transform.position = Input.mousePosition;
        GetComponent<RectTransform>().anchoredPosition = Input.mousePosition;
        //RectTransform.anchoredPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End drag");
        //Instantiate(chestslot);
        //transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            m_PointerEventData = new PointerEventData(m_EventSystem);
            m_PointerEventData.position = Input.mousePosition;

        }

        List<RaycastResult> results = new List<RaycastResult>();
        raycaster.Raycast(eventData, results);

        foreach (var item in results)
        {
            Debug.Log(item.gameObject.name);
        }
        


    }
}
