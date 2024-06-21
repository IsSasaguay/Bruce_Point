using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    [SerializeField] private AudioClip coinSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ManagerAudio.unicaInstancia.PlaySound(coinSound);
            Destroy(gameObject);
        }
    }
}
