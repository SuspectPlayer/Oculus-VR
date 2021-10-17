using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnChairTrigger : MonoBehaviour
{
    public TriggerChairOn chairTriggerScript;
    public Transform playersRB;

    public Transform playerTransform;
    public Transform parentTransform;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerTransform.SetParent(parentTransform);
            chairTriggerScript.ChairOn();
        }
        Debug.Log("Enter " + other.name);
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerTransform.SetParent(parentTransform);
            chairTriggerScript.ChairOn();
        }
        Debug.Log("Stay " + other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerTransform.SetParent(null);
            chairTriggerScript.ChairOff();
        }
        Debug.Log("Exit " + other.name);
    }
}
