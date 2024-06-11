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
        Recolectar();
    }

    public void Recolectar()
    {
       

        //presionar teclaE
        if (Input.GetKeyDown(KeyCode.E))
           

        {
            Estela.SetActive(false);
            estelaParticulas.SetActive(true);
            Stats_Player.estela = 1;
            Invoke("TiempoPanel", 3f);
            
        }
                    
    }
    public void TiempoPanel()
    {
        panelinfoEstela.SetActive(true);
    }

}
