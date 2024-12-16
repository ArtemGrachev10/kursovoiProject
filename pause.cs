using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject panel; //чтоб отображалась ячейка панельки в скрипте


     public void Pause() // метод в котором сама пауза
    {
        Time.timeScale = 0f; // время равно нулю
        panel.SetActive(true); // панель работает
    }

}
