using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioNiveles : MonoBehaviour
{
    public Matriz Niveles;
    public GameObject ImagenNivel; //Aqui estamos hablando del canvas
    public void NivelEjecutar()
    {
        ImagenNivel.SetActive(true);
        FindObjectOfType<DisplayNiveles>().StartLevel(Niveles);
    }
}
