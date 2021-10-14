using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSoundPlayer : MonoBehaviour
{
    public AudioClip detected;
    public AudioClip open;
    public AudioClip slide;
    public AudioClip close;
    public AudioSource audioSource;
    public Transform detectedPos;
    public Transform openClosePos;
    public Transform slidePos;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void PlayDetected()
    {
        Vector3 pos = detectedPos.position;
        AudioSource.PlayClipAtPoint(detected, pos);
    }
    public void PlayOpen()
    {

        Vector3 pos = openClosePos.position;
        AudioSource.PlayClipAtPoint(open, pos);
    }
    public void PlaySlide()
    {

        Vector3 pos = slidePos.position;
        AudioSource.PlayClipAtPoint(slide, pos);
    }
    public void PlayClose()
    {

        Vector3 pos = openClosePos.position;
        AudioSource.PlayClipAtPoint(close, pos);
    }
}
