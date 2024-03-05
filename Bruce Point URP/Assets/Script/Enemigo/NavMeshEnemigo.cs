using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Rendering.DebugUI;

public class NavMeshEnemigo : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform pointer;

    //variables para distancias
    public float LookRadius = 50f;
    public float DistanciaDisparo = 25f;

    public Animator animator;
    public GameObject Bala;
    public Transform PointerBala;

    //Variables temporizador de la bala
    public float tiempo;
    public float tiemporestante;

    public int vida;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        FaceTarget();
        float distancia = Vector3.Distance(pointer.position, transform.position);
        if (distancia <= LookRadius) 
        {
            agent.SetDestination(pointer.position);
            animator.SetBool("Walk", true);
            agent.speed = 5f;

            if (distancia  <= DistanciaDisparo) 
            {
                animator.SetBool("Disparo", true);
                agent.speed = 0f;
                DisparaBala();
            }

            else 
            {
                animator.SetBool("Disparo", false);
            }

        }
        else 
        {
            animator.SetBool("Walk", false);
            agent.speed = 0f;
        }

        Debug.Log(distancia);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            vida = vida - 20;

            if (vida == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    //Codigo Gizmos de color para rangos
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, DistanciaDisparo);

    }

    //Seguimiento y rotacion del enemigo
    void FaceTarget  ()
    {
        Vector3 direccion = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direccion.x, 0, direccion.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f);
    }

    //Isntanciar bala
    void DisparaBala ()
    {
        tiemporestante = tiemporestante - Time.deltaTime;

        if (tiemporestante <= 0) 
        {
            Instantiate(Bala, PointerBala.position, transform.rotation);
            Resetear();
        }
    }
    void Resetear ()
    {
        tiemporestante = tiempo;
    }
}

