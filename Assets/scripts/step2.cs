using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step2 : MonoBehaviour
{
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;
    public GameObject flower4;
    public ParticleSystem particleSystem2;
    public ParticleSystem particleSystem3;
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
        if (other.CompareTag("Flower1"))
        {
            // Deactivate flower1 and activate flower3
            flower1.SetActive(false);
            flower3.SetActive(true);
            audioSource.Play();

        }
        else if (other.CompareTag("Flower2"))
        {
            // Deactivate flower2 and activate flower4
            flower2.SetActive(false);
            flower4.SetActive(true);
            audioSource.Play();

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!flower1.activeSelf && !flower2.activeSelf)
        {
            // Both Flower1 and Flower2 are inactive, deactivate particleSystem2 and activate particleSystem3
            particleSystem2.gameObject.SetActive(false);
            particleSystem3.gameObject.SetActive(true);
        }
    }
}