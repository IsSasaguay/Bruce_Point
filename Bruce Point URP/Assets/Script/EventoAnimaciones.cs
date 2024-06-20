using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoAnimaciones : MonoBehaviour
{
    public AudioSource Source;
    public Transform particulaPointer;
    public AudioClip ClipAttack;
    public AudioClip ClipAttackSuper;
    public AudioClip ClipSalto;
    public GameObject particulaAttack;
    public GameObject particulaAttackSuper;
    public GameObject Bala;
    public GameObject BalaGema;

    public void EfectAttack()
    {
        Source.PlayOneShot(ClipAttack);
        Instantiate(particulaAttack, particulaPointer);
        Instantiate(Bala, particulaPointer);
    }
    public void EfectAttackSuper()
    {
        Source.PlayOneShot(ClipAttackSuper);
        Instantiate(particulaAttackSuper, particulaPointer);
        Instantiate(BalaGema, particulaPointer);
    }
    public void EfectoSalto()
    {
        Source.PlayOneShot(ClipSalto);
        
    }
}
