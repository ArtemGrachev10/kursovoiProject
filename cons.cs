using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cons : MonoBehaviour
{
    public GameObject panel; // чтобы панельку было видно в скрипте

    public void ContinueGame() // метод продолжить игру
    {
        Time.timeScale = 1f; // время равно обычному
        panel.SetActive(false);// панель уходит
    }
}
