using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickEasy()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void OnClickNormal()
    {
        SceneManager.LoadScene("Stage2");
    }

    public void OnClickHard()
    {
        SceneManager.LoadScene("Stage2");
    }
}
