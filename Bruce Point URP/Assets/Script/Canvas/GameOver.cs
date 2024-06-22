using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Button continueButton;
    private GameObject player;
    private Load_Save_Character savePoint;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        savePoint = FindObjectOfType<Load_Save_Character>();
    }

    private void OnContinueButtonClicked()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1; // Reanudar el juego

        
        

        // Colocar al jugador en la posición del punto de guardado
        player.transform.position = savePoint.transform.position;
    }
}
