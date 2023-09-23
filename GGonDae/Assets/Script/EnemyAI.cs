using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public int nextdX, nextdY;
    public Rigidbody2D rb;
    public float moveSpeed = 1f;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction();
    }
    void FixedUpdate()
    {

    }
    void Direction()
    {
        nextdX = Random.Range(-2, 3);
        nextdY = Random.Range(-2, 3);
        rb.velocity = new Vector2(nextdX, nextdY);
        Invoke("Direction", 2);
    }
}