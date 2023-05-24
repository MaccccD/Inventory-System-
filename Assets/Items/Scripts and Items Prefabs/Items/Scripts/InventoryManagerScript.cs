using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryManagerScript : MonoBehaviour
{
    public GameObject SlotPrefab;
    public List<ItemsObjects> itemSlots = new List<ItemsObjects>(8);
    public static event HandleItemBought OnItemBought;
    public delegate void HandleItemBought(ItemsObjects Items);
    public ItemsObjects items;
    private GameObject newItemSlot;


    public void ResetContent()
    {
        foreach (Transform childTransform in transform)
        {
            Destroy(childTransform.gameObject);
            OnItemBought.Invoke(items);
            SceneManager.LoadScene("ShopScene");

        }
        itemSlots = new List<ItemsObjects>(8);
    }
}

