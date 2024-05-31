using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNiveles : MonoBehaviour
{
    public Queue <string> nivelMatriz;
    
    public Text textoNombre;
    public Text textoDescripcion;
    public Image imagenIlustracion;

    public Niveles nivel1;
    public Niveles nivel2;
    public Niveles nivel3;

    void Start()
    {
        nivelMatriz = new Queue<string>();
    }
    public void StartLevel(Matriz nivel)
    {
        textoNombre.text = nivel.name;
        nivelMatriz.Clear();

        foreach (string cambioNivel in nivel.nivelMatriz)
        {
            nivelMatriz.Enqueue(cambioNivel);
        }
        DisplayNextLevel();
    }

    public void DisplayNextLevel()
    {
        if (nivelMatriz.Count == 0)
        {
            return;
        }
        string cambioNivel = nivelMatriz.Dequeue();
        textoNombre.text = cambioNivel;
        textoDescripcion.text = cambioNivel;
        
    }

    public void ParametroNivel1()
    {
        textoNombre.text = nivel1.nombreNivel;
        textoDescripcion.text = nivel1.descripcionNivel;
        imagenIlustracion.sprite = nivel1.imagenNivel;
    }

    public void ParametroNivel2()
    {
        textoNombre.text = nivel2.nombreNivel;
        textoDescripcion.text = nivel2.descripcionNivel;
        imagenIlustracion.sprite = nivel2.imagenNivel;
    }
    public void ParametroNivel3()
    {
        textoNombre.text = nivel3.nombreNivel;
        textoDescripcion.text = nivel3.descripcionNivel;
        imagenIlustracion.sprite = nivel3.imagenNivel;
    }
}
