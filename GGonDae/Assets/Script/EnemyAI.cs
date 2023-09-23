using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public int nextdX, nextdY;
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float traceSpeed = 1.5f;
    bool isMoving = true;
    bool isTracing = false;
    GameObject traceTarget;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Direction();
        Invoke("Direction", 2);
    }

    void Update()
    {

        if (isTracing == true)
        {
            isMoving = false;
            Trace();
        }
    }
    void Direction()
    {
        if (isMoving == true)
        {
            nextdX = Random.Range(-2, 3);
            nextdY = Random.Range(-2, 3);
            rb.velocity = new Vector2(nextdX, nextdY);
            Invoke("Direction", 2);
        }
    }
    void Trace() { 
        if(isTracing == true) {
            Vector2 playerPos = traceTarget.transform.position;
            Debug.Log(playerPos - new Vector2(transform.position.x, transform.position.y));

            rb.velocity = playerPos - new Vector2(transform.position.x, transform.position.y);
            Direction();
        }
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"){
            traceTarget = other.gameObject;
            Debug.Log("asdfa");
            isMoving = false;
            isTracing = true;
        }
    }
}