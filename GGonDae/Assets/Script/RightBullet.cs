using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBullet : MonoBehaviour
{
    GameObject player;
    public float bulletSpeed = 10.0f;

    void Start()
    {
        this.player = GameObject.Find("Boat2");
        transform.position = this.player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime, 0, 0);
    }
}
