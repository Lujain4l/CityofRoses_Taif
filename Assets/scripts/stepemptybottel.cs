using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class stepemptybottel : MonoBehaviour
{



    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject particleSystem3;
    public GameObject Emptybottel1;
    public GameObject Emptybottel2;
    public TextMeshProUGUI countdownText;
    public GameObject fillwater;
    public AudioClip audioClip;
    public AudioSource audioSource;
    public GameObject canva1;
    public GameObject canva2;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = audioClip;
        }

      
    }


    private IEnumerator DeactivateParticleSystemAfterDelay(float delay)
    {
        // countdown timer
        float timer = delay;
        while (timer > 0f)
        {
            countdownText.text = Mathf.CeilToInt(timer).ToString(); // Display timer
            yield return new WaitForSeconds(1f); 
            timer -= 1f;
            audioSource.Play();
        }

        if (particleSystem3 != null)
        {
            particleSystem3.SetActive(false);
            canva1.SetActive(false);

        }
        if (fillwater != null)
        {
            fillwater.SetActive(true);

        }
        if (particleSystem2 != null)
        {
            particleSystem2.SetActive(true);
            canva2.SetActive(true);
        }

        countdownText.gameObject.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("emptybottel"))
        {
            Debug.Log("player put the empty bottle");
            StartCoroutine(DeactivateParticleSystemAfterDelay(10f));

            if (particleSystem1 != null)
            {
                particleSystem1.SetActive(false);
            }
           
            if (particleSystem3 != null)
            {
                particleSystem3.SetActive(true);
            }
            if (Emptybottel1 != null)
            {
                Emptybottel1.SetActive(false);
            }
            if (Emptybottel2 != null)
            {
                Emptybottel2.SetActive(true);
            }
        }
    }






}
