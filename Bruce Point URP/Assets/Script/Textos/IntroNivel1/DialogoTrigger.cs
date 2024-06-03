using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogoTrigger : MonoBehaviour
{
    public Dialoge dialogo;
    public GameObject imagenDialogo;

    public void DialogueTrigger()
    {
        imagenDialogo.SetActive(true);
        FindObjectOfType<DialogoManager>().StartDialogue(dialogo);
    }

    public void TriggerSalir()
    {
        imagenDialogo.SetActive(false);
    }
}
