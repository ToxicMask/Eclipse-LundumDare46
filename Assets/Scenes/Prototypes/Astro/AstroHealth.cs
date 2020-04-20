using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroHealth : MonoBehaviour
{
    [SerializeField] float maxAir = 100f;
    [SerializeField] float playerAir = 100f;
    [SerializeField] float loseAir = 1f;

    // Ui Component

    // Start is called before the first frame update
    void Start()
    {
        RestoreAir();
    }

    // Update is called once per frame
    void Update()
    {
        // Lose Air
        LoseAir();

        // Check for Death
        if (playerAir < 0) Death();
    }

    public void RestoreAir()
    {
        playerAir = maxAir;
    }

    void LoseAir()
    {
        playerAir -= loseAir * Time.deltaTime;
    }

    void Death()
    {
        Debug.LogWarning("Player Death");
        Application.Quit();
    }
}
