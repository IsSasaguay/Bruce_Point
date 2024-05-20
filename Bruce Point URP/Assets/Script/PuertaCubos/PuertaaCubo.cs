using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaaCubo : MonoBehaviour
{
    public GameObject puertaCubos;
    public GameObject particulaExplosion;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AttackPlayer")) // Colisionar con el tag 
        {
            // Instanciar la part�cula de explosi�n
            Instantiate(particulaExplosion, transform.position, Quaternion.identity);

            // Dispersar los cubos
            DispersarCubos();

            // Desactivar la puerta principal
            gameObject.SetActive(false);
        }
    }

    void DispersarCubos()
    {
        // Instanciar los cubos dispersos en la misma posici�n y rotaci�n que la puerta principal
        Instantiate(puertaCubos, transform.position, transform.rotation);
    }
}