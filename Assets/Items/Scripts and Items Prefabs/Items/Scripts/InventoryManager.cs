using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class InventoryManager : MonoBehaviour
{ 
    public GameObject imagetobeinsideslot;
    //[SerializeField] List<ItemsObjects> itemList = new List<ItemsObjects>(8);
    //public GameObject[] itemSlots;
    [SerializeField] List<GameObject> i_itemSlots = new List<GameObject>(6);
    [SerializeField] new List<GameObject> items = new List<GameObject>(13);
    
    public bool BuyButton = true;
    //[SerializeField] ItemsObjects Items;


    public void Start()
    {

    }
     public void AddItem( ItemsObjects items )
    {
        if (BuyButton == true)
        {
            //items.Add(items);
        }
        
        
          //for (var i = 0; i < _items.Count; i++)
        {
           // Instantiate(_items[i], new Vector3(0, 0, 0), Quaternion.identity);
        }






            //GameObject prefabslot = Instantiate(slotPrefab);
            //Instantiate(prefabslot, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);

        }
        
    }
    

// item = info.transform.Gameobject
// _item


