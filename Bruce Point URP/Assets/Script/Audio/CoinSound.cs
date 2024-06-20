using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    
    [SerializeField] private AudioClip coinSound;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ManagerAudio.unicaInstancia.PlaySound(coinSound);
            Destroy(gameObject);
            
        }
    }
    
    void Update()
    {
        
    }
}
