using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{
    public static Stats_Player instance; //

    

    public static float vida = 100f; //Varaiable estatica vida
    public static float monedasPuntos;
    public static float gemas = 3;
    public static float estela;

    public GameObject panel;
    public GameObject panelDialogos;
    public Transform pointerDano;
    public GameObject danoAtaque;
    
    public float tiempo = 1f;
    public float tiemporestante = 0f;




    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "MagiaEnemigo")
        {
            vida = vida - 10;
            Destroy(collision.transform.gameObject);
            Invoke("Dano", 0f);

            if (vida <= 0)
            {
                panel.SetActive(true); // Mensaje de perdiste en la consola
                Time.timeScale = 0;// El tiempo del juego se detenga
            }
            else
            {
                Time.timeScale = 1;
            }
        }

        if (collision.transform.tag == "AtaqueEnemigo")
        {
            vida = vida - 5;
            Invoke("Dano", 0f);

            if (vida <= 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
            
        }
        //Curacion
        if (collision.transform.tag == "Curacion")
        {
            vida = vida + 25;
            Destroy(collision.transform.gameObject);
        }
        //Contador monedas
        if (collision.transform.tag == "Coin")
        {
            monedasPuntos = monedasPuntos + 1;
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
    //Efectos al recibir daño
    void Dano()
    {
        Instantiate(danoAtaque, pointerDano.position, transform.rotation);
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


    //Pausar el juego hasta leer todos los dialogos
   /* public void PausaPanel()
    {
        panelDialogos.SetActive(true);
        Time.timeScale = 0;
    }*/
}
