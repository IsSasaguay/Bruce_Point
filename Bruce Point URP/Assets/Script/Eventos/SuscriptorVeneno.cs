using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SuscriptorVeneno : MonoBehaviour
{
    public GameObject player;
    //FLechas TRAMPAS
    public GameObject FlechasT1;
    public GameObject FlechasT2;
    public GameObject FlechasT3;   
    public GameObject FlechasT4;

   
    void Start()
    {
        
    }
    //invocar flechas en los grupos de trampas tipo FLECHAS de 1 - 3
    public void InvocarFlechasT1()
    {
        FlechasT1.SetActive(true);
    }
    public void OcultarFlechasT1()
    {
        FlechasT1.SetActive(false);
    }

    public void InvocarFlechasT2()
    {
        FlechasT2.SetActive(true);
    }
    public void OcultarFlechasT2()
    {
        FlechasT2.SetActive(false);
    }
    public void InvocarFlechasT3()
    {
        FlechasT3.SetActive(true);
    }
    public void OcultarFlechasT3()
    {
        FlechasT3.SetActive(false);
    }
    public void InvocarFlechasT4()
    {
        FlechasT4.SetActive(true);
    }
    public void OcultarFlechasT4()
    {
        FlechasT4.SetActive(false);
    }

        
}
