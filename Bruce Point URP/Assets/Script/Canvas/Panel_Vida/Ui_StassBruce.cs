using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_StassBruce : MonoBehaviour
{
    public Text Textovida;
    public Text textoPuntos;
    public Text textoGemas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Controlar vida con texto
        Textovida.text = "Vida:" + Stats_Player.vida;
        // Controlar la recoleccion de monedas
        textoPuntos.text = "Puntos: " + Stats_Player.monedasPuntos;
        // Controlar la recoleccion de gemas
        textoGemas.text = "Gemas: " + Stats_Player.gemas;
    }
}
