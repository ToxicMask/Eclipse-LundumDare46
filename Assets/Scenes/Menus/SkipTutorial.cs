﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTutorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FinalLevel");
    }
}
