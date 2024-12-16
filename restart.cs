using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;
public class restart : MonoBehaviour
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
        if (k % 5 == 0 && Advertisement.IsReady())
        {
            Advertisement.Show();

        }









    }


        public void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        }
    
        
    

 }
