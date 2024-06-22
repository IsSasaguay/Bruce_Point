using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public static float vida;
    public static float gema;
    public static float monedas;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<Stats_Player>().lastCheckpoint = GetComponent<Transform>().position;
            vida = Stats_Player.vida;
            gema = Stats_Player.gemas;
            monedas = Stats_Player.monedasPuntos;
        }
    }
}
