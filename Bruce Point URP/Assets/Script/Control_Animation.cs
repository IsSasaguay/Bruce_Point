using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Animation : MonoBehaviour
{
    Animator animator;
    const float AnimationSmoothTime = 0.05f;
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

        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift)) 
        {
            Magnitude /= 0.5f;
        }

        animator.SetFloat("SpeedPercent", Magnitude, AnimationSmoothTime, Time.deltaTime );

        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }
}
