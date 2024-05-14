using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreTrampa : MonoBehaviour
{
    public GameObject triggerCofre; //Objeto para trigger de trampa
    public int vidaCofre;
    //particulas y pointer
    public GameObject particulaCofre;
    public Transform Pointerparticula;
    //tesoro de cofre
    public GameObject tesoroCofre;
    
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
                Invoke("InvocarTriggerT4", 0f);
                Invoke("Particula", 0f);
                Invoke("Tesoro", 0f);
                Destroy(gameObject);
            }
        }
    }

    public void InvocarTriggerT4()
    {
        triggerCofre.SetActive(true);
    }
    void Particula()
    {
        Instantiate(particulaCofre, Pointerparticula.position, transform.rotation);
    }
    void Tesoro()
    {
        Instantiate(tesoroCofre, Pointerparticula.position, transform.rotation);
    }
}
