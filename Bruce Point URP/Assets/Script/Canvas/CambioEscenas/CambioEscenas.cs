using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CambioEscenas : MonoBehaviour
{
    public GameObject panelOpciones;
    public GameObject panelNiveles;
    public GameObject panelNJuego;
    public GameObject panelContinuar;
    //Panel de Opciones
    public GameObject panelVideo;
    public GameObject panelAudio;

    //Panel de Niveles
    public GameObject niveles;

    
    public void CargarEscena1()
    {
        SceneManager.LoadScene(1);
    }

    //Panel de Opciones
    public void MenuOpciones()
    {
        panelOpciones.SetActive(true);
    }
    public void MenuOpcionesOff()
    {
        panelOpciones.SetActive(false);
    }
    //                  //
    public void MenuVideo()
    {
        panelVideo.SetActive(true);
    }
    public void MenuVideoOff()
    {
        panelVideo.SetActive(false);
    }
    //                  //
    public void MenuAudio()
    {
        panelAudio.SetActive(true);
    }
    public void MenuAudioOff()
    {
        panelAudio.SetActive(false);
    }

    //Panel de Niveles
    public void MenuNiveles()
    {
        panelNiveles.SetActive(true);
    }
    public void MenuNivelesOff()
    {
        panelNiveles.SetActive(false);
    }

}
