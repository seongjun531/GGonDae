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
        Invoke("Direction", 5);
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(nextdX, nextdY);
    }
    void Direction()
    {
        nextdX = Random.Range(-1, 2);
        nextdY = Random.Range(-1, 2);

        Invoke("Direction", 5);
    }
}