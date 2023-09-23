using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float playerSpeed = 3.0f;
    public float maxSpeed = 100.0f;
    Rigidbody2D rid2D;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (rid2D.velocity.x < maxSpeed)
            {
                rid2D.AddForce(new Vector2(playerSpeed, 0), ForceMode2D.Force);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rid2D.AddForce(new Vector2(-playerSpeed, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rid2D.AddForce(new Vector2(0, playerSpeed), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rid2D.AddForce(new Vector2(0, -playerSpeed), ForceMode2D.Force);
        }
    }
}
