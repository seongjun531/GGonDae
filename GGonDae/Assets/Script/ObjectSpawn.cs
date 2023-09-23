using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObjectSpawn : MonoBehaviour
{
    public GameObject prefabs;
    public GameObject Door;
    public int rand;

    void Start()
    {
        for(int i = 0; i<=rand; i++){
            int randx = Random.Range(-10,10);
            int randy = Random.Range(-6, 6);
           
            Instantiate(prefabs, new Vector2(randx, randy), Quaternion.identity);
        }      
    }

    void Update()
    {
        if (rand == 0){
            Door.GetComponent<TilemapCollider2D>().isTrigger = true;
        }
    }
    void OnTriggerExit2D(){
        Door.GetComponent<TilemapCollider2D>().isTrigger = false;
    }
}
