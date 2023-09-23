using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DoorControl : MonoBehaviour
{
    public bool isOpen = false;
    void OnTriggerEnter2D(Collider2D other){
        isOpen = true;
    }
    void OnTriggerStay2D(Collider2D other){
        if(Input.GetKey(KeyCode.F)){
            GetComponent<TilemapCollider2D>().enabled = false;
            GetComponent<TilemapRenderer>().enabled = false;
        }
    }
    void OnTriggerExit2D(Collider2D other){
        GetComponent<TilemapCollider2D>().enabled = true;
        GetComponent<TilemapRenderer>().enabled = true;
    }
}
