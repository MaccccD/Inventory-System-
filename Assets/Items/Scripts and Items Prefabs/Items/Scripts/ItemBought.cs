using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemBought : MonoBehaviour
{
    [SerializeField] List<GameObject> ImagesofboughtItems = new List<GameObject>(4);
    [SerializeField] Image SniperImageBackpack;
    [SerializeField] Image AK47ImageBackpack;
    //[SerializeField] Image HealthPowerUpImageBackpack;
    //[SerializeField] Image twotimesspeedImageBackpack;
    public List<GameObject> i_itemSlots = new List<GameObject>();


}



