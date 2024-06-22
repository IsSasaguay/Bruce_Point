using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Stats_Player : MonoBehaviour
{
    public static Stats_Player instance; //


    public static float vida = 100f; //Varaiable estatica vida
    public static float monedasPuntos;
    public static float gemas = 3;
    public static float estela;
    

    public  GameObject panel;
    public GameObject panelDialogos;
    public Transform pointerDano;
    public GameObject danoAtaque;
    
    public float tiempo = 1f;
    public float tiemporestante = 0f;

    public AudioSource Source;
    public AudioClip ClipGameOver;

    public Vector3 lastCheckpoint;


    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        vida = 100;
        gemas = 3;
        monedasPuntos = 0;
    }

    public void Update()
    {
        if (vida <= 0)
        {
            GetComponent<CharacterController>().enabled = false;
            transform.position = lastCheckpoint;
            panel.SetActive(true);
            GetComponent<CharacterController>().enabled = true;
            vida = CheckPoint.vida;
            gemas = CheckPoint.gema;
            monedasPuntos = CheckPoint.monedas;
            
        }

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
                
                EfectGameOver();
                ;// El tiempo del juego se detenga
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
                EfectGameOver();
                
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
                
                EfectGameOver();
                
            }
            
        }

        //Daño por veneno
        if (collision.transform.tag == "Veneno")
        {
            InvokeRepeating ("DanoVeneno", 0f, tiempo); //Daño continuo de veneno y fuego
            if (vida <= 0)
            {
                panel.SetActive(true);
                
            }
            
        }

        //Daño por lanzas trampas
        if (collision.transform.tag == "Flecha")
        {
            DanoLanzas();
            if (vida <= 0)
            {
                EfectGameOver();
                
            }
            
        }
        //Daño por Neblina
        if (collision.transform.tag == "Neblina")
        {
            MuerteNeblina();
            if (vida <= 0)
            {
                
                EfectGameOver();
                
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

    void MuerteNeblina()
    {
        vida = 0;
    }
    //Pausar el juego hasta leer todos los dialogos
    /* public void PausaPanel()
     {
         panelDialogos.SetActive(true);
         Time.timeScale = 0;
     }*/

    public void Continuar()
    {
        
        panel.SetActive(false);
        Time.timeScale = 1;
    }
    //Metodos para sonidos de panel GameOver
    public void EfectGameOver()
    {
        Source.PlayOneShot(ClipGameOver);
    }
    

}
