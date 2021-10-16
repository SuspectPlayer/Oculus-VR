using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed;
    public float x;
    public float y;
    public float z;

    public bool turnOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (turnOn)
        {
            transform.Rotate(new Vector3(x, y, z) * rotationSpeed * Time.deltaTime);
        }
    }

    public void TurnOn()
    {
        turnOn = true;
    }
    public void TurnOff()
    {
        turnOn = false;
    }
}
