using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackpackInventory : MonoBehaviour
{
    private GameObject[] itemSlots;
    [SerializeField] private GameObject itemsParent;
    [SerializeField] List<ItemsObjects> Items;
   


    public void Start()
    {
        itemSlots = new GameObject[itemsParent.transform.childCount];
        //To set the slots to attach to the sot holder 
        for (int i = 0; i < itemsParent.transform.childCount; i++)
        {
            itemSlots[i] = itemsParent.transform.GetChild(i).gameObject;
            RefreshUI();
        }
    }
    public void RefreshUI()
    {
        
        for (int i = 0; i < itemSlots.Length; i++)
        {

            try
            {
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().enabled = true;
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = Items[i].ItemIcon;
            }
            catch
            {
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;
                itemSlots[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
            }


        }
    }
}


