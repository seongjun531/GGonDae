using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyAI : MonoBehaviour
{
    public int nextdX, nextdY;
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float traceSpeed = 1.5f;
    public float Hp = 1000.0f;
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
            if (playerPos.x < transform.position.x){
                rb.velocity = new Vector2(-traceSpeed, rb.velocity.y);
            }

            else if(playerPos.x > transform.position.x){
                rb.velocity = new Vector2(traceSpeed, rb.velocity.y);
            }

            if (playerPos.y < transform.position.y){
                rb.velocity = new Vector2(rb.velocity.x, -traceSpeed);
            }

            else if(playerPos.y > transform.position.y){
                rb.velocity = new Vector2(rb.velocity.x, traceSpeed);
            }
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