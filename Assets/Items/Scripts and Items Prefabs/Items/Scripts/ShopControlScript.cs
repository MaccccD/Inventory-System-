using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ShopControlScript : MonoBehaviour
{
	public float MoneyAmount = 100;
	public TMP_Text moneyAmountText;
	//public int PriceText;
	[SerializeField] Image ImageBackpack;
	public Text BackpackFull;
	public bool Buybutton = true;
	int SniperStackBackpack;
	int SniperStackShop;





	void Start()
	{
		//PriceText = 
		moneyAmountText.text = "MoneyAmount: " + MoneyAmount.ToString();

	}
	public void Buy(ItemsObjects itemtobuy)
	{
		if (MoneyAmount >= itemtobuy.Price)
		{
			MoneyAmount -= itemtobuy.Price;
			ImageBackpack.enabled = true;
			moneyAmountText.text = "MoneyAmount: " + MoneyAmount.ToString();
			Buybutton = true;
		}
		if(ImageBackpack == null)
        {
			ImageBackpack.enabled = true;
        }
		else 
		{
			Buybutton = false;
		}

	}
	public void Resell(ItemsObjects itemtobuy)
	{
		if (MoneyAmount >= 0)
		{
			MoneyAmount += itemtobuy.Price;
			Destroy(ImageBackpack);
			moneyAmountText.text = "MoneyAmount: " + MoneyAmount.ToString();
			Buybutton = true;

		}
	}
	public void Upgrade(ItemsObjects spaceincrease)
	{
		if (MoneyAmount >= spaceincrease.Price)
		{
			MoneyAmount -= spaceincrease.Price;
			ImageBackpack.enabled = true;
			moneyAmountText.text = "MoneyAmount: " + MoneyAmount.ToString();
			Buybutton = true;


		}

	}
	public void AddItemtostack()
	{
		if ((SniperStackShop < 5) && (SniperStackBackpack < 5))
		{
			SniperStackShop = SniperStackShop + 1;

		}
		else if (SniperStackBackpack >= 5)
		{
			BackpackFull.text = ("The  backpack can not carry anymore snipers, please move some to the Chest");
		}
		else if (SniperStackShop >= 5)
		{
			BackpackFull.text = ("The  backpack will not carry anymore snipers, you may remove some in the shop");
		}
	}
	public void GainMoreItems(ItemsObjects itemtobuy)
	{
		if (MoneyAmount >= 30)
		{
			MoneyAmount += 70;
			ImageBackpack.enabled = true;
			moneyAmountText.text = "MoneyAmount: " + MoneyAmount.ToString();
			Buybutton = true;

		}
		else
		{
			Buybutton = false;
		}



	}
}