using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_StassBruce : MonoBehaviour
{
    public Text Textovida;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Controlar vida con texto
        Textovida.text = "Vida:" + Stats_Player.vida;
    }
}
