using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    private float timer = 1.5f;
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f){
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        GameObject go = other.gameObject;
        if(go != null ||go.tag == "Player"){
            PlayerManager player = go.GetComponent<PlayerManager>();
            player.PlayerHp -= 30.0f;
        }
    }
}
