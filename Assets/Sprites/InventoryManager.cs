using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class inventorymanager: MonoBehaviour 
{
    public static inventorymanager instance;

    [SerializeField] List<ItemsObjects> itemList = new List<ItemsObjects>(8);
    [SerializeField] KeyCode itemPickUpKeyCode = KeyCode.K;
    [SerializeField] ItemsObjects item;
    [SerializeField] Transform ItemContent;
    
    
    private bool BuyButton = true;


    public void AddItem(ItemsObjects items)
    {
        if (BuyButton && Input.GetKeyDown(itemPickUpKeyCode))
        {
            Destroy(gameObject);
            itemList.Add(item);
            //ScriptableObject.CreateInstance<ItemsObjects>();
            

        }

    }

}





