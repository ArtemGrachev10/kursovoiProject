using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cons : MonoBehaviour
{
    public GameObject panel; // ����� �������� ���� ����� � �������

    public void ContinueGame() // ����� ���������� ����
    {
        Time.timeScale = 1f; // ����� ����� ��������
        panel.SetActive(false);// ������ ������
    }
}
