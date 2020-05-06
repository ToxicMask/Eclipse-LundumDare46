using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void NewGame()
    {
        Debug.Log("@");
        SceneManager.LoadScene("Tutorial");
    }


    public void Exit()
    {
        Debug.Log("#");
        Application.Quit();
    }
}
