using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SharkController : MonoBehaviour
{
    public float Hp = 1000.0f;
    public float sharkdamage = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.gameObject;
        if (player != null)
        {
            PlayerManager playerhp = player.GetComponent<PlayerManager>();
            
            playerhp.PlayerHp -= sharkdamage;
        
        }
    }
}
