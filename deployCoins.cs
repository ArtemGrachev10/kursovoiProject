using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class deployCoins : MonoBehaviour
{
    public GameObject coinPrefab;
    public float respawnTime = 5.0f;
    private Vector2 screenBounds;


    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CoinWave());
    }

    private void SpawnCoin()
    {
        GameObject a = Instantiate(coinPrefab) as GameObject;
        a.transform.position = new Vector3(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator CoinWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnCoin();
        }
    }

}
