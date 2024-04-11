using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Stats_Player : MonoBehaviour
{

    public int vida = 100;
    public GameObject panel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "MagiaEnemigo")
        {
            vida = vida - 20;
            Destroy(collision.transform.gameObject);

            if(vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }

        }

        if (collision.transform.tag == "AtaqueEnemigo")
        {
            vida = vida - 10;
            Destroy(collision.transform.gameObject);

            if (vida == 0)
            {
                panel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
