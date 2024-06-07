using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    
    public int vidaCofre;
    //particulas y pointer
    public GameObject particulaCofre;
    public Transform Pointerparticula;
    public Transform Pointertesoro1;
    public Transform Pointertesoro2;
    //tesoro de cofre
    public GameObject tesoro1;
    public GameObject tesoro2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "AttackPlayer")
        {
            vidaCofre = vidaCofre - 20;
            if (vidaCofre <= 0)
            {
                
                Invoke("Particula", 0f);
                Invoke("Tesoro", 0f);
                Destroy(gameObject);
            }
        }
    }

    
    void Particula()
    {
        Instantiate(particulaCofre, Pointerparticula.position, transform.rotation);
    }
    void Tesoro()
    {
        Instantiate(tesoro1, Pointertesoro1.position, transform.rotation);
        Instantiate(tesoro2, Pointertesoro2.position, transform.rotation);
    }
}
