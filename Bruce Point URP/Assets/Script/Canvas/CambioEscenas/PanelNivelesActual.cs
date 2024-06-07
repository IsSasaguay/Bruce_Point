using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelNivelesActual : MonoBehaviour
{
    public GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        Invoke("Activacion", 3f);
        Invoke("Desactivar", 6f);
    }
    
     public void Activacion()
    {
        panel.SetActive(true); // Mensaje de perdiste en la consola
        Time.timeScale = 0;// El tiempo del juego se detenga
    }
    public void Desactivar()
    {
        panel.SetActive(false); // Mensaje de perdiste en la consola
        
    }

}
