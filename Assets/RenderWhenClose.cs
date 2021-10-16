using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderWhenClose : MonoBehaviour
{
    public Transform player;
    public float distance;
    public float maxDistance = 4;
    public MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        if(distance < maxDistance)
        {
            meshRenderer.enabled = true;
        }
        else
        {
            meshRenderer.enabled = false;
        }
    }
}
