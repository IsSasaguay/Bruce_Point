using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosBotones : MonoBehaviour
{
    [SerializeField] private AudioClip BotonSound;
    [SerializeField] private AudioClip BotonSalirSound;
    
    public void SonidoBoton()
    {
        ManagerAudio.unicaInstancia.PlaySound(BotonSound);
    }
    public void SalirSonido()
    {
        ManagerAudio.unicaInstancia.PlaySound(BotonSalirSound);
    }
}
