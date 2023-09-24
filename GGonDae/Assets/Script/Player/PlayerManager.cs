using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    Animator animator;
    public float PlayerHp = 100.0f;
    public bool isdie = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isdie == true)
        {
            Invoke("DieScene", 2f);   
        }
        playerdie();
    }
    public void playerdie()
    {
        if(PlayerHp <= 0)
        {
            isdie = true;
            animator.SetBool("UpBool", false);
            animator.SetBool("DownBool", false);
            animator.SetBool("DieTrigger", true);
        }
    }
    public void DieScene()
    {
        SceneManager.LoadScene("SelectScene");
    }
}
