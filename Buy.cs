using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy : MonoBehaviour
{

    public GameObject BuyButton;
    int BuySkin;

    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
    }


    void Update()
    {
        if (BuySkin == 1)
        {
            BuyButton.SetActive(true);
        }
        else
        {
            BuyButton.SetActive(false);
        }


    }

    public void BuySkins()
    {
        if(MoneyText.Coin >= 99)
        {
           MoneyText.Coin -= 99;
            PlayerPrefs.SetInt("Coins", MoneyText.Coin);
            BuySkin = 2;
            PlayerPrefs.GetInt("BuySkin", BuySkin);
        }
    }



    
}
        
    
