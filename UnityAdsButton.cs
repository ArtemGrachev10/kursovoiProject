using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;



public class UnityAdsButton : MonoBehaviour
{

    public static int k;
    bool testMode = false; //потом надо поставить false

     void Start()
    {

        k = PlayerPrefs.GetInt("ii", k);

        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("4429525", testMode);
        }
    }





    public void ShowAd()
    {
        k += 1;
        if (k % 3==0 && Advertisement.IsReady())
        {
            Advertisement.Show(); 

        }

       

        
       
        

        
        
     }
      

        
    
}
