using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaSound : MonoBehaviour
{
    [SerializeField] private AudioClip coinSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("SuperAtack"))
        {
            ManagerAudio.unicaInstancia.PlaySound(coinSound);
           
        }
    }
}