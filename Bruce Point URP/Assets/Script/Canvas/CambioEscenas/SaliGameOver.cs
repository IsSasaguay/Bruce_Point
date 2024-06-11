using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaliGameOver : MonoBehaviour
{
    public void CargarEscena0()
    {
        SceneManager.LoadScene(0);
        //Hasta mientras para poder reiniciar el juego sin que la pantalla esté congelada
        Time.timeScale = 1;
    }
}
