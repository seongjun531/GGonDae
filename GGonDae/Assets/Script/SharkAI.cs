using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkAI : EnemyAI
{
    public float tSpeed = 2.0f;
    public override void Awake()
    {
        base.Awake();
    }
    void Update()
    {

    }

    public override void Direction()
    {
        if (isMoving == true)
        {
            nextdX = Random.Range(-2, 3);
            nextdY = Random.Range(-2, 3);
            rb.velocity = new Vector2(nextdX, nextdY);
            Invoke("Direction", 2);
        }
        else if(isTracing==true){
            rb.velocity = new Vector2(0, 0);
            Invoke("Trace", 3);
        }
    }

    public override void Trace()
    {
        if(isTracing == true){
            Vector2 playerPos = traceTarget.transform.position;
            rb.velocity = (playerPos - new Vector2(transform.position.x, transform.position.y))*tSpeed;
            isMoving = true;
            isTracing = false;
        }
        Debug.Log("Trace End");
        Direction();
    }
}
