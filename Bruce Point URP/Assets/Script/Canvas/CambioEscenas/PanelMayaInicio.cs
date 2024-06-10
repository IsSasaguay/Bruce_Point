using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMayaInicio : MonoBehaviour
{
    public GameObject panel1; // Panel 1 permanece activo
    public GameObject panel2; // Panel 2 que se activara después de algunos segundos

    private float timer = 0f; // Temporizador

    void Start()
    {
        
        panel1.SetActive(true);
        panel2.SetActive(false);
       
    }

    void Update()
    {
        // Incrementar el temporizador
        timer += Time.deltaTime;

        // Verificar si han pasado dichos segundos
        if (timer >= 3f)
        {
            // Desactivar el panel 1
            panel1.SetActive(false);
            // Activar el panel 2
            panel2.SetActive(true);
           
        }
    }
}

