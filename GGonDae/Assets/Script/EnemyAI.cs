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
        nextdX = Random.Range(-1, 2);
        nextdY = Random.Range(-1, 2);
        rb.velocity = new Vector2(nextdX, nextdY);
        Invoke("Direction", 2);
    }
}