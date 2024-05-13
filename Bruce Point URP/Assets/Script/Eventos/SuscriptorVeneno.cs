using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SuscriptorVeneno : MonoBehaviour
{
    public GameObject player;
    public GameObject Flechas;
    public GameObject ElmEvento;
    public GameObject Fuego;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InvocarFlechas()
    {
        Flechas.SetActive(true);
    }
    public void OcultarFlechas()
    {
        Flechas.SetActive(false);
    }

    public void FuegoActive()
    {
        Fuego.SetActive(true);
    }
    public void OcultarFfuego()
    {
        if (ElmEvento != null)
        {
            Fuego.SetActive(false);
        }
    }
        
}
