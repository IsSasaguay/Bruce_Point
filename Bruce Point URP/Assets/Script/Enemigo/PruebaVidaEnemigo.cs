using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaVidaEnemigo : MonoBehaviour
{
    public int vida =50;

    // COLLISION COD
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "AttackPlayer")
        {
            vida -= 20; // Reducir vida en -20 puntos

            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}