using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNiveles : MonoBehaviour
{
    public Niveles nivel1;
    public Niveles nivel2;
    public Niveles nivel3;
    public Text textoNombre;
    public Text textoDescripcion;
    public Image imagenIlustracion;
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
}
