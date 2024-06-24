using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia : MonoBehaviour
{
    public Vector3 Direccion;
    public float Speed;
    void Start()
    {
        Destroy(gameObject, 2.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Direccion*Speed*Time.deltaTime);
    }
}
