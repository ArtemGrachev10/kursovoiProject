using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.height, Camera.main.transform.position.z));
    }

    
    void Update()
    {
       
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("killer"))
        {
            Destroy(gameObject);
        }
    }


}
