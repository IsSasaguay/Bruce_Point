using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventoMaya : MonoBehaviour
{
    public AudioSource Source;
    public AudioClip ClipAttack;

    public void EfectAttack()
    {
        Source.PlayOneShot(ClipAttack);
    }
}
