using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    int nextdX, nextdY;
    public Rigidbody2D rb;
    public float traceSpeed = 1.5f;
    public float Hp = 1000.0f;
    bool isMoving = true;
    bool isTracing = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("Direction", 2);
    }
    void FixedUpdate()
    {

    }
    void Direction()
    {
        if (isMoving){
            nextdX = Random.Range(-2, 3);
            nextdY = Random.Range(-2, 3);
            rb.velocity = new Vector2(nextdX, nextdY);
            Invoke("Direction", 2);
        }

        else if(isTracing) {
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
        }
        
    }
    void OnTriggerEnter2D(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            traceTarget - other.gameObject;

            isMoving = false;
        }
    }
    void OnTriggerStay2D(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            isTracing = true;
        }
    }
}