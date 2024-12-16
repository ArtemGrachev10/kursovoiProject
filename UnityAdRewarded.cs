using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnityAdRewarded : MonoBehaviour
{
   
    public Text rewardtext;
    int n = 15;
    
    

    public void ShowRewardedVideo()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
            MoneyText.Coin += n;
            

           
            
            


        }

        

        
        
    }




}
