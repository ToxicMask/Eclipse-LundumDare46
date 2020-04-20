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
    public AirSupplyUI airUI;

    // Start is called before the first frame update
    void Start()
    {
        // Auto Get

        airUI = GameObject.FindGameObjectWithTag("PlayerUI").GetComponentInChildren<AirSupplyUI>();

        // Set to max
        playerAir = maxAir;

        // Config Air UI
        airUI.SetMaxAir(playerAir);
    }

    // Update is called once per frame
    void Update()
    {
        // Lose Air
        LoseAir();

        // Update UI
        airUI.SetAir(playerAir);

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

    public void IncreaseMaxAir(float plusValue)
    {
        maxAir += plusValue;
        RestoreAir();
    }

    void Death()
    {
        Debug.LogWarning("Player Death");
        Application.Quit();
    }
}
