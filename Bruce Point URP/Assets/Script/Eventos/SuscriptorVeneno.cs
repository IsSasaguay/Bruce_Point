using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuscriptorVeneno : MonoBehaviour
{
    public GameObject player;
    public GameObject Flechas;
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
}
