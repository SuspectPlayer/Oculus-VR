using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChairOn : MonoBehaviour
{
    public bool chairOn;
    public Animator animator;

    
    public void ChairOn()
    {
        chairOn = true; animator.SetBool("ChairOn", true);
    }

    public void ChairOff()
    {
        chairOn = false; animator.SetBool("ChairOn", false);
    }
}
