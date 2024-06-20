using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    public static ManagerAudio unicaInstancia;

    private AudioSource audioSource;     // Para sonidos generales como monedas
    

    private void Awake()
    {
        // Implementaci�n del patr�n Singleton
        if (unicaInstancia == null)
        {
            unicaInstancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            
        }

        
        audioSource = GetComponent<AudioSource>();
       // if (audioSource == null)
       // {
     //       audioSource = gameObject.AddComponent<AudioSource>();
      //  }

 
    }

    public void PlaySound(AudioClip soundClip)
    {
        if (soundClip != null)
        {
            audioSource.PlayOneShot(soundClip);
        }
        else
        {
            Debug.LogWarning("No se proporcion� un AudioClip para reproducir sonido.");
        }
    }

   
}

