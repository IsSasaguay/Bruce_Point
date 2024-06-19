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

    public void EfectAttack()
    {
        Source.PlayOneShot(ClipAttack);
        Instantiate(particulaAttack, particulaPointer);
    }
    public void EfectAttackSuper()
    {
        Source.PlayOneShot(ClipAttackSuper);
        Instantiate(particulaAttackSuper, particulaPointer);
    }
    public void EfectoSalto()
    {
        Source.PlayOneShot(ClipSalto);
        
    }
}
