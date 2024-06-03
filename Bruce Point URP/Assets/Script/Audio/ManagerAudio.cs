using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerAudio : MonoBehaviour
{
    public static ManagerAudio unicaInstancia;
    private void Awake()
    {
        if (ManagerAudio.unicaInstancia == null)
        {
            ManagerAudio.unicaInstancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
