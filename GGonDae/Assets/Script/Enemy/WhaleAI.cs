using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleAI : EnemyAI
{
    public override void Awake()
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
            rb.velocity = new Vector2(nextdX, nextdY)*1.2f;
            Invoke("Direction", 2);
        }
        else if(isTracing==true){
            Invoke("Trace", 3);
        }
    }
    protected override void Trace()
    {
        if(isTracing == true){
            GameObject player = traceTarget;
            if (player != null)
            {
                PlayerManager playerhp = player.GetComponent<PlayerManager>();
            
                playerhp.PlayerHp -= 50.0f;
        
            }
        }
        Invoke("Direction", 2);
    }
}
