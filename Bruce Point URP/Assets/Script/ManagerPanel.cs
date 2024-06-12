using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPanel : MonoBehaviour
{
    public static ManagerPanel isntanciaUnica;

    /*private void Awake()
    {
        if (ManagerPanel.isntanciaUnica == null)
        {
            ManagerPanel.isntanciaUnica = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }*/
}
