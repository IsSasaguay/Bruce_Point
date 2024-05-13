using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class TrampaPiso : MonoBehaviour
{
    public GameObject piso;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            piso.transform.Translate(0f, 0f, -0.15f);
        }
    }
}
