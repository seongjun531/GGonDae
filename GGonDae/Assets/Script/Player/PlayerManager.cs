using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
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
            SceneManager.LoadScene("SelectScene");
        }
        playerdie();
    }
    public void playerdie()
    {
        if(PlayerHp <= 0)
        {
            isdie = true;
        }
    }
}
