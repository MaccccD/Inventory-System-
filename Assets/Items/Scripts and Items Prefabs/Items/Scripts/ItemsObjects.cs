using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ItemsObjects : MonoBehaviour
{
    public Sprite ItemIcon;
    public string ItemName;
    public int Price;
    
    [SerializeField] List<GameObject> items = new List<GameObject>(13);
    public  List<GameObject> i_itemSlots = new List<GameObject>();
    [SerializeField] List<GameObject> SpaceIncrease = new List<GameObject>(8);

    public void Start()
    {
        items = new List<GameObject>();
        items = new List<GameObject>();
    }
    
}

    
    



