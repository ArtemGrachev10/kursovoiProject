using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class UnityAdsInitialize : MonoBehaviour
{

    private string gameId = "4429525";

    void Start()
    {
        Advertisement.Initialize(gameId, true);
    }


}


