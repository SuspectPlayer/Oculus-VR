using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HologramEffect : MonoBehaviour
{
    public Transform target;
    public float distance;
    private MeshRenderer meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);
        float difference = 10 - distance; 
        Material[] mats = meshRenderer.materials;
        mats[0].SetFloat("_FresnelPower", difference);

        meshRenderer.materials = mats;
    }
}
