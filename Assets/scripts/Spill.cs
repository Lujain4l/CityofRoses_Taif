using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill : MonoBehaviour
{

    public AudioClip audioClip;
    public AudioSource audioSource;
    ParticleSystem spillparticle;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = audioClip;
        }

        spillparticle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spillparticle != null)
        {
            float angle = Vector3.Angle(transform.up, Vector3.down);
            float tolerance = 0.1f; // Define a tolerance value

            if (angle >= (90f + tolerance))
            {
                if (!spillparticle.isPlaying)
                {
                    spillparticle.Play();
                    audioSource.Play();

                }
            }
            else
            {
                if (spillparticle.isPlaying)
                {
                    spillparticle.Stop();
                    audioSource.Stop();
                }
            }
        }
    }

}
