using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class EventoElemental : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip ClipAttack;
    public AudioClip ClipIddle;
    public GameObject Poder;
    public Transform particulaPointer;
    

    public void EfectAttack()
    {
        Source.PlayOneShot(ClipAttack);
        
        Instantiate(Poder, particulaPointer.position, transform.rotation);
    }
    public void EfectIddle()
    {
        Source.PlayOneShot(ClipIddle);
    }
}
