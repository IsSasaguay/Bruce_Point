using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Publisher_Player : MonoBehaviour
{
    [SerializeField] private UnityEvent EnterTrigger;
    [SerializeField] private UnityEvent ExitTrigger;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            EnterTrigger.Invoke();
        }
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            ExitTrigger.Invoke();
        }
    }
}

