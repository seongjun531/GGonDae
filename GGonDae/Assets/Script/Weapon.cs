using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float currTime;
    public float shootdelay = 2.0f;
    public GameObject upbullet;
    public GameObject downbullet;
    public GameObject rightbullet;
    public GameObject leftbullet;
    public Animator animator;


    void Start()
    {
        currTime = shootdelay + 1;
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > shootdelay)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("DownBool", true);
                Instantiate(rightbullet);
                currTime = 0;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                Instantiate(leftbullet);
                currTime = 0;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("UpBool", true);
                Instantiate(upbullet);
                currTime = 0;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Instantiate(downbullet);
                currTime = 0;
            }
        }
    }


}
