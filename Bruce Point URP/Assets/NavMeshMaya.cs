using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Rendering.DebugUI;

public class NavMeshMaya : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform pointer;

    //variables para distancias
    public float LookRadius = 50f;
    public float DistanciaAtaque = 25f;
    public GameObject Gema;
    public Transform PointerGema;
    //particulas de daño recibido
    public Transform pointerDano;
    public GameObject danoAtaque;

    //variables para ataque
    public Animator animator;

    //variables para vida
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
            animator.SetBool("Walking", true);
            agent.speed = 5f;
            bool attack01;
            bool attack02;
            if (distancia <= DistanciaAtaque)
            {
                animator.SetBool("Attacking01", true);
                agent.speed = 0f;
                attack01 = true;
                if (attack01 == true)
                {
                    animator.SetBool("Attacking02", true);
                    attack02 = true;
                    if (attack02 == true) 
                    {
                        animator.SetBool("Attacking03", true);
                        attack01 = false;
                    }
                }
            }

            else
            {
                animator.SetBool("Attacking01", false);
            }

        }
        else
        {
            animator.SetBool("Walking", false);
            agent.speed = 0f;
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "SuperAtack") //Ataque patada Bruce
        {
            vida = vida - 200;
            Invoke("Dano", 0f);
            if (vida <= 0)
            {
                animator.SetBool("Dyeing", true);
                Invoke("GemasPoder", 4f);
                DestruirObjeto();

            }

        }

        if (collision.transform.tag == "AttackPlayer") //Ataque disparo bruce
        {
            vida = vida - 20;
            Invoke("Dano", 0f);
            if (vida <= 0)
            {
                animator.SetBool("Dyeing", true);
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
        Gizmos.DrawWireSphere(transform.position, DistanciaAtaque);

    }
    //Seguimiento y rotacion del enemigo
    void FaceTarget()
    {
        Vector3 direccion = (pointer.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direccion.x, 0, direccion.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 1f);
    }
    void DestruirObjeto()
    {
        // Destruye este objeto
        Destroy(gameObject, 5f);

    }
    void GemasPoder()
    {
        Instantiate(Gema, PointerGema.position, transform.rotation);
    }
    //Método de daño recibido
    void Dano()
    {
        Instantiate(danoAtaque, pointerDano.position, transform.rotation);
    }
}
