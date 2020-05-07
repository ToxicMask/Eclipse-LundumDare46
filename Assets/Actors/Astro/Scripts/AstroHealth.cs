using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroHealth : MonoBehaviour
{
    [SerializeField] float maxAir = 80f;
    [SerializeField] float playerAir = 80f;
    [SerializeField] float loseAir = 4f;

    // Ui Component
    public AirSupplyUI airUI;

    // Start is called before the first frame update
    void Start()
    {
        // Auto Get
        GameObject playerUI = GameObject.FindGameObjectWithTag("PlayerUI");

        airUI = (playerUI != null ) ? playerUI.GetComponentInChildren<AirSupplyUI>() : null;

        // Set to max
        playerAir = maxAir;

        // Config Air UI
        if (airUI != null) airUI.SetMaxAir(playerAir);
    }

    // Update is called once per frame
    void Update()
    {
        // Lose Air
        LoseAir();

        // Update UI
        if (airUI != null) airUI.SetAir(playerAir);

        //Debug.Log(playerAir);

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

        // Update UI
        if (airUI != null) airUI.SetMaxAir(maxAir);
    }

    void Death()
    {
        Debug.LogWarning("Player Death");
        SceneManager.LoadScene("DeathScene");
    }
}
