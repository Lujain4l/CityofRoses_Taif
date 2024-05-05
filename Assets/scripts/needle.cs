using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class needle : MonoBehaviour
{
    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject fillneedle;
    public GameObject canva1;
    public GameObject canva2;



    private IEnumerator DeactivateParticleSystemAfterDelay(float delay)
    {
        // countdown timer
        float timer = delay;
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;

        }

        if (particleSystem1 != null)
        {

            Destroy(canva1);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("needle"))
        {

            if (particleSystem1 != null)
            {
                Destroy(particleSystem1); 
            }

            if (particleSystem2 != null)
            {
                particleSystem2.SetActive(true);
                canva2.SetActive(true);
            }

            if (fillneedle != null)
            {
                fillneedle.SetActive(true);
            }

        }
    }
}