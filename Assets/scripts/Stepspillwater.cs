using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stepspillwater : MonoBehaviour
{
    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject particleSystem3;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject fillwat;



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
        if (other.CompareTag("Water"))
        {
            Debug.Log("player pourwater");

            if (particleSystem1 != null)
            {
                particleSystem1.SetActive(false);
            }
            if (particleSystem3 != null)
            {
                Destroy(particleSystem3);
            }
            if (particleSystem2 != null)
            {
                particleSystem2.SetActive(true);

            }
            if (canva2 != null) {
                canva2.SetActive(true);
            }


            if (fillwat != null)
            {
                fillwat.SetActive(true);
            }
        }
    }
}
