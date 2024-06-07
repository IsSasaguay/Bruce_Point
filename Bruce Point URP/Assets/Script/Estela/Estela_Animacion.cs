using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estela_Animacion : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        {
            animator = GetComponentInChildren<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
