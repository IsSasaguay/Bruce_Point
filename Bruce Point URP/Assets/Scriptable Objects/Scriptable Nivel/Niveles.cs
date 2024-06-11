using System.Collections;
using System.Collections.Generic;
//using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Nivel", menuName = "Imagen Nivel")]

public class Niveles : ScriptableObject
{
    public string nombreNivel;
    public string descripcionNivel;
    public Sprite imagenNivel;
    
}
