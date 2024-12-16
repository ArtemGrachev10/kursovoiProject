using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject exp; // отобразится в инспекторе
    public GameObject lost;


    void Start()
    {
        Time.timeScale = 1f;
    }


    void OnTriggerEnter2D(Collider2D collision) //метод для соприкосновений
    {
        if (collision.tag == ("my"))
        {
            exp.SetActive(true);
            Destroy(gameObject);
            lost.SetActive(true);
        }
    }
}
