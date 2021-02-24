using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float SpeedofCars;
    public Rigidbody2D rb;
    public static float speed = 1f;

    public float minSpeed = 2f;
    public float maxSpeed = 6f;
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "CarDestroyer")
        {
            Destroy(this.gameObject);
        }
    }
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }
}
