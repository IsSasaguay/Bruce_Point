using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{

    public static float vida = 150f; //Varaiable estatica vida
    public GameObject panel;
    public int monedas;
    public int gemas;
    public float tiempo = 1f;
    public float tiemporestante = 0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "MagiaEnemigo")
        {
            vida = vida - 20;
            Destroy(collision.transform.gameObject);

            if (vida <= 0)
            {
                panel.SetActive(true); // Mensaje de perdiste en la consola
                Time.timeScale = 0;// El tiempo del juego se detenga
            }

        }

        if (collision.transform.tag == "AtaqueEnemigo")
        {
            vida = vida - 5;
            

            if (vida <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
        //Contador monedas
        if (collision.transform.tag == "Coin")
        {
            monedas = monedas + 1;
            Destroy(collision.transform.gameObject);
        }

        //Contador gemas
        if (collision.transform.tag == "Gema")
        {
            gemas = gemas + 1;
            Destroy(collision.transform.gameObject);
        }

        //Daño por flechas
        if (collision.transform.tag == "Flecha")
        {
            DanoFlechas();
            Destroy(collision.transform.gameObject);
            if (vida <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        //Daño por veneno
        if (collision.transform.tag == "Veneno")
        {
            InvokeRepeating ("DanoVeneno", 0f, tiempo); //Daño continuo de veneno y fuego
            if (vida <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }

        //Daño por lanzas trampas
        if (collision.transform.tag == "Flecha")
        {
            DanoLanzas();
            if (vida <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    //Daño TRAMPAS
    public void DanoVeneno()
    {
        tiemporestante = tiemporestante - Time.deltaTime; //Daño continuo de veneno y fuego
        if (tiemporestante <= 0f)
        {
            vida = vida - 25;
            Resetear();
        }
        
    }
    void Resetear() //Temporizador daño de veneno y fuego
    {
        tiemporestante = tiempo;
    }

    public void DanoFlechas() // Daño flechas
    {
        vida = vida - 25;
    }
    public void DanoLanzas() // Daño flechas
    {
        vida = vida - 25;
    }
}
