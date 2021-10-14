using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorAnimation : MonoBehaviour
{
    public Animator animator;
    public GameObject target;
    public float distance;
    private void Start()
    {

    }
    private void Update()
    {
        

        distance = Vector3.Distance(target.transform.position, transform.position);

        if (distance < 4)
        {
            animator.SetBool("Open", true);

        }
        else
        {
            animator.SetBool("Open", false);

        }

    }
}
