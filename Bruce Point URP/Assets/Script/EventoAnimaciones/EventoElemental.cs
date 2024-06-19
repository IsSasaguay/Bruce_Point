using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoElemental : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip ClipAttack;
    public AudioClip ClipIddle;

    public void EfectAttack()
    {
        Source.PlayOneShot(ClipAttack);
    }
    public void EfectIddle()
    {
        Source.PlayOneShot(ClipIddle);
    }
}
