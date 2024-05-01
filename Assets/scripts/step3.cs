using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step3 : MonoBehaviour
{
    public GameObject flower5;
    public GameObject flower6;
    public AudioClip audioClip;
    public AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = audioClip;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Flower5"))
        {
            audioSource.Play();
            flower5.SetActive(false);
            flower6.SetActive(true);
        }


    }
  
}