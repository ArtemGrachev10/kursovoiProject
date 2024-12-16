using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Coins : MonoBehaviour

{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    [SerializeField] private int numberTap;
    [SerializeField] private Text numberTapText;
    [HideInInspector] private const string leaderBoard = "CgkI2P2KtLUPEAIQAQ";
   


   void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.height, Camera.main.transform.position.z));
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag ==("Semen"))
        {
            MoneyText.Coin += 1;
            PlayerPrefs.SetInt("coins", MoneyText.Coin);
            Destroy(gameObject);
            Social.ReportScore(MoneyText.Coin,leaderBoard,(bool success) => { });


        }
        if (collision.tag == ("killerAss"))
        {
            Destroy(gameObject);
        }
      
        
        

        
    }

    

    public void ShowLeaderBoard()
    {
        Social.ShowLeaderboardUI();
    }

    public void ExitFromGPS()
    {
        PlayGamesPlatform.Instance.SignOut();
    }
}
