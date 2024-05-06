using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1 : MonoBehaviour
{

    public GameObject basket1;
    public GameObject basket2;
    public GameObject particleSystem1;
    public GameObject Canva1;




    private IEnumerator DeactivateParticleSystemAfterDelay(float delay)
    {
        float timer = delay;
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;

        }

        if (Canva1 != null)
        {

            Canva1.SetActive(false);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player enter");
            StartCoroutine(DeactivateParticleSystemAfterDelay(40f));
            // Deactivate basket 1
            if (basket1 != null)
            {
                basket1.SetActive(false);
            }

            // Activate basket 2
            if (basket2 != null)
            {
                basket2.SetActive(true);
            }

            // Deactivate particle system 1
            if (particleSystem1 != null)
            {
                particleSystem1.SetActive(false);
            }
          
        }
    }
}