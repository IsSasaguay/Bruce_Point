using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Load_Save_Character : MonoBehaviour
{
    
    public float vida;
    public float gema;
    public float monedas;
    
    public void SavePosition()
    {
        
        vida = Stats_Player.vida;
        gema = Stats_Player.gemas;
        monedas = Stats_Player.monedasPuntos;
        
        
        
    }
    
}
