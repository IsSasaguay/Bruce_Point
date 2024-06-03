using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_StassBruce : MonoBehaviour
{
    public Text Textovida;
    public Text textoPuntos;
    public Text textoGemas;

    //barras de vida y gemas
    public Image barraVida;
    public float vidaActual;
    public float vidaMaxima = 100f;

    public Image barraGema;
    public float gemaActual;
    public float gemaMaxima = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Controlar vida con texto
        Textovida.text = "" + Stats_Player.vida;
        // Controlar la recoleccion de monedas
        textoPuntos.text = "" + Stats_Player.monedasPuntos;
        // Controlar la recoleccion de gemas
        textoGemas.text = "" + Stats_Player.gemas;
        //controlar vida con imagen
        vidaActual = Stats_Player.vida;
        barraVida.fillAmount = vidaActual/vidaMaxima;
        //controlar gema con imagen
        gemaActual = Stats_Player.gemas;
        barraGema.fillAmount = gemaActual / gemaMaxima;
    }
}
