using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step2 : MonoBehaviour
{
    public GameObject flower1;
    public GameObject flower2;
    public GameObject flower3;
    public GameObject flower4;

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
        if (other.CompareTag("flowers"))
        {
            if (!flower1.activeSelf)
            {
                flower1.SetActive(true);
                audioSource.Play();
                other.gameObject.SetActive(false);
            }
            else if (!flower2.activeSelf)
            {
                flower2.SetActive(true);
                audioSource.Play();
                other.gameObject.SetActive(false);
            }
            else if (!flower3.activeSelf)
            {
                flower3.SetActive(true);
                audioSource.Play();
                other.gameObject.SetActive(false);
            }
            else if (!flower4.activeSelf)
            {
                flower4.SetActive(true);
                audioSource.Play();
                other.gameObject.SetActive(false);
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (!flower1.activeSelf && !flower2.activeSelf && !flower3.activeSelf)
        {
         
            particleSystem3.gameObject.SetActive(true);
        }
    }
}