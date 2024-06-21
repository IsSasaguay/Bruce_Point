using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_Save_Character : MonoBehaviour
{
    public float x, y, z;
    public float vida;
    public float gema;
    public float monedas;
    public void SavePosition()
    {
        
        vida = Stats_Player.vida;
        gema = Stats_Player.gemas;
        monedas = Stats_Player.monedasPuntos;
        x = transform.position.x;
        y= transform.position.y;
        z= transform.position.z;

        PlayerPrefs.SetFloat("x",x);
        PlayerPrefs.SetFloat("y",y);
        PlayerPrefs.SetFloat("z",z);
        PlayerPrefs.Save();
        
    }
    
    public void LoadPotition()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 loadPosition = new Vector3(x,y,z);
        transform.position = loadPosition;
    }
}
