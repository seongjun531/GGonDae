using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleAI : EnemyAI
{
    /*public override void Awake()
    {
        base.Awake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected override void Direction()
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
            Debug.Log(rb.velocity);
            Trace();
        }
    }
    protected override void Trace()
    {
        if(isTracing == true){
            Player player = traceTarget.GetComponent<PlayerManager>();
            player.PlayerHp -= 50.0f;
            isMoving = true;
            isTracing = false;
        }
        Debug.Log("Trace End");
        Invoke("Direction", 2);
    }*/
}
