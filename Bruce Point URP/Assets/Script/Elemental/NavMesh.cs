using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Rendering.DebugUI;

public class NavMesh : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform pointer;

    //variables para distancias
    public float LookRadius = 50f;
    public float DistanciaDisparo = 25f;

    //variables para ataque
    public Animator animator;
    public GameObject Ataque;
    public Transform PointerAtaque;
    public GameObject Explosion;
    public GameObject Gema;
    public Transform PointerExplosion;
    public Transform PointerGema;
    // public ParticleSystem Particulaexplosion;

    //Variables temporizador ataque
    public float tiempo;
    public float tiemporestante;

    public int vida;

    
    
    public float retrasoInicial = 2f;
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

            if (distancia <= DistanciaDisparo)
            {
                animator.SetBool("Magia", true);
                agent.speed = 0f;
                Invoke("DisparaMagia", retrasoInicial);
            }

            else
            {
                animator.SetBool("Magia", false);
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
        if (collision.transform.tag == "PatadaPlayer")
        {
            vida = vida - 10;

            if (vida <= 0)
            {
                animator.SetBool("Muerte", true);
                CancelInvoke("DisparaMagia");
                Invoke("Explo", 2f);
                Invoke("GemasPoder", 4f);

                DestruirObjeto();

            }

        }
        if (collision.transform.tag == "AttackPlayer")
        {
            vida = vida - 20;

            if (vida <= 0)
            {
                animator.SetBool("Muerte", true);
                CancelInvoke("DisparaMagia");
                Invoke("Explo", 2f);
                Invoke("GemasPoder", 4f);

                DestruirObjeto();

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
    void FaceTarget()
    {
        Vector3 direccion = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direccion.x, 0, direccion.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f);
    }

    //Isntanciar ataque
    void DisparaMagia()
    {
        tiemporestante = tiemporestante - Time.deltaTime;

        if (tiemporestante <= 0f)
        {
            Instantiate(Ataque, PointerAtaque.position, transform.rotation);
            Resetear();
        }
    }
    void Resetear()
    {
        tiemporestante = tiempo;
    }
    //Particulaexplosion
    void Explo()
    {
       Instantiate(Explosion, PointerExplosion.position, transform.rotation);
       
        
    }
    // Destruye este objeto
    void DestruirObjeto()
    {
        
        Destroy(gameObject, 4f);
        
    }
    //Gema 
    void GemasPoder()
    {
        Instantiate(Gema, PointerGema.position, transform.rotation);
    }
}

