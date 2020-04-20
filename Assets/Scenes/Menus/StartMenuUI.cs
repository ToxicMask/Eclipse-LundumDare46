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
        SceneManager.LoadScene("CompassTest");
    }


    public void Exit()
    {
        Application.Quit();
    }
}
