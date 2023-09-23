using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBullet : MonoBehaviour
{
    GameObject player;
    public float bulletSpeed = 10.0f;
    public float bulletDamage = 100.0f;
    void Start()
    {
        this.player = GameObject.Find("Boat2");
        transform.position = this.player.transform.position;
        transform.position = new Vector3(transform.position.x + 1.5f, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(bulletSpeed * Time.deltaTime, 0, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject enemy = GameObject.Find("Shark");
        if (enemy != null)
        {
            SharkController enemyHP = enemy.GetComponent<SharkController>();
            if (collision.gameObject.tag.Equals("Enemy"))
            {
                enemyHP.Hp -= bulletDamage;
                Destroy(this.gameObject);
            }
        }
    }
}
