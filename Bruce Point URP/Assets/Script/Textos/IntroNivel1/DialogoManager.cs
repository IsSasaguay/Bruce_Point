using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour
{
    public Queue<string> sentences;
    public Text NameText;
    public Text dialogueText;

    [SerializeField] private AudioClip BotonSound;
    


    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialoge dialogue)
    {
        NameText.text=dialogue.name;
        sentences.Clear();
        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }

    public void DisplayNextSentences()
    {
        if(sentences.Count == 0) 
        {
            return;
        }
        string sentece = sentences.Dequeue();
        dialogueText.text= sentece;
        ManagerAudio.unicaInstancia.PlaySound(BotonSound);
    }
     
}
