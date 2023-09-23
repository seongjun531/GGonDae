using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpBullet : MonoBehaviour
{
    GameObject player;
    public float bulletSpeed = 10.0f;
    public float bulletDamage = 100.0f;
    void Start()
    {
        this.player = GameObject.Find("Boat2");
        transform.position = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, bulletSpeed * Time.deltaTime, 0);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject enemy = collision.gameObject;
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
