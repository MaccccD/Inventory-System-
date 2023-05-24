using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlots : MonoBehaviour, IDropHandler
{
    //public Image  ItemIcon;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Draggginganddropping draggableitem = dropped.GetComponent<Draggginganddropping>();
        draggableitem.parentAfterDrag = transform;
    }
    //public TMP_Text ItemName;
    //public int ItemPrice;



}