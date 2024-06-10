using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarObj : MonoBehaviour
{
    // Start is called before the first frame upda
    public GameObject panelinfoEstela;
    public GameObject Estela;
    public GameObject estelaParticulas;


    // Update is called once per frame
    public void Update()
    {
        //presionar teclaE
        if (Input.GetKeyDown(KeyCode.E))

        {
            Recolectar();
        }
    }

    public void Recolectar()
    {
        Estela.SetActive(false);
        panelinfoEstela.SetActive(true);
        estelaParticulas.SetActive(true);

    }

}
