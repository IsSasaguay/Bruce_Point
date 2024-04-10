using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBruce : MonoBehaviour
{
    public Animator animator;
    public float tiempovuelo;
    public float tiemporestante;

    void Start()
    {
        {
            animator = GetComponentInChildren<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        Pirueta();
        if (tiemporestante <= 1f)
        {
            animator.SetBool("Giro", true);

        }
        else
        {

            animator.SetBool("Giro", false);
        }

    }
    void Pirueta()
    {
        tiemporestante = tiemporestante - Time.deltaTime;
        if (tiemporestante <= 0f)
        {
            Resetear();
        }


    }
    void Resetear()
    {
        tiemporestante = tiempovuelo;
    }

}
