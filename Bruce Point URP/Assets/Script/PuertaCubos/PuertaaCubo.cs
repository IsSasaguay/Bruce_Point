using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaaCubo : MonoBehaviour
{
    public GameObject puertaCubos;
    public GameObject particulaExplosion;

    // Tiempo en segundos antes de destruir la partícula de explosión
    public float tiempoDestruccionParticula = 2f;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SuperAtack")) // Colisionar con el tag 
        {
            // Instanciar la partícula de explosión
            GameObject particula = Instantiate(particulaExplosion, transform.position, Quaternion.identity);

            // Destruir la partícula después de un tiempo especificado
            Destroy(particula, tiempoDestruccionParticula);

            // Dispersar los cubos
            DispersarCubos();

            // Desactivar la puerta principal
            gameObject.SetActive(false);

            DestruirPuerta();
        }
    }

    void DispersarCubos()
    {
        // Instanciar los cubos dispersos en la misma posición y rotación que la puerta principal
        Instantiate(puertaCubos, transform.position, transform.rotation);
    }

    public void DestruirPuerta()
    {
        Destroy(gameObject, 4f);
    }
}