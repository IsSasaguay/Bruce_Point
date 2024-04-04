using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Animation : MonoBehaviour
{
    Animator animator;
    public GameObject arma; // Objeto Arma Bruce
    const float AnimationSmoothTime = 0.05f;
    public GameObject BalaPlayer; // Objeto bala Bruce
    public Transform PointerBala; // Objeto Pointer de arma

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(x, 0f, z);
        float Magnitude = Mathf.Clamp01(move.magnitude);

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Magnitude /= 0.5f;
        }

        animator.SetFloat("SpeedPercent", Magnitude, AnimationSmoothTime, Time.deltaTime);

        // Activacion de Ataque con click Izquierdo
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }

        // Activacion de Disparo pistola con click Derecho
        if (Input.GetButton("Fire2"))
        {
            animator.SetBool("PistolaAttack", true);
            if (arma != null)
            {
                arma.SetActive(true); // Activar Arma Bruce
                Disparo(); // Llamar al método Disparo para instanciar la bala
            }
        }
        else
        {
            animator.SetBool("PistolaAttack", false);
            if (arma != null)
            {
                arma.SetActive(false); // Desactivar Arma Bruce
            }
        }
    }
    // Instancia BalaBruce
    void Disparo()
    {
        Instantiate(BalaPlayer, PointerBala.position, transform.rotation);
    }
}