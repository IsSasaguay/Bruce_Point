using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{

    public int vida = 100;
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

            if(vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }

        }

        if (collision.transform.tag == "AtaqueEnemigo")
        {
            vida = vida - 10;
            Destroy(collision.transform.gameObject);

            if (vida == 0)
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

        //Da�o por flechas
        if (collision.transform.tag == "Flecha")
        {
            DanoFlechas();
            Destroy(collision.transform.gameObject);
        }

        //Da�o por veneno
        if (collision.transform.tag == "Veneno")
        {
            InvokeRepeating ("DanoVeneno", 0f, tiempo); //Da�o continuo de veneno

        }
    }



    //Da�o TRAMPAS
    public void DanoVeneno()
    {
        tiemporestante = tiemporestante - Time.deltaTime; //Da�o continuo de veneno
        if (tiemporestante <= 0f)
        {
            vida = vida - 25;
            Resetear();
        }
        
    }
    void Resetear() //Da�o continuo de veneno
    {
        tiemporestante = tiempo;
    }

    public void DanoFlechas()
    {
        vida = vida - 25;
    }
    public void DanoFuego() //Da�o trigger de fuego
    {
        vida = vida - 25;
    }


}
