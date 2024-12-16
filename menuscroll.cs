using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuscroll : MonoBehaviour
{

    float scrollSpeed = -45f;
    Vector2 startPos;
    void Start()
    {
        startPos = transform.position;
    }


    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scrollSpeed, 11);
        transform.position = startPos + Vector2.right * newPos;
    }
}
