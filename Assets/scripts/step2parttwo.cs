using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step2parttwo : MonoBehaviour
{
    public GameObject particleSystem1;
    public GameObject particleSystem2;
    public GameObject canvas1;
    public GameObject canvas2;



    private IEnumerator DeactivateParticleSystemAfterDelay(float delay)
    {
        // countdown timer
        float timer = delay;
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;
          
        }

        if (canvas1 != null)
        {

            canvas1.SetActive(false);
        }


    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player COMPLETE STEP");
            StartCoroutine(DeactivateParticleSystemAfterDelay(15f));

            if (particleSystem1 != null)
            {
                particleSystem1.SetActive(false);
            }
            if (particleSystem2 != null)
            {
                particleSystem2.SetActive(true);
                canvas2.SetActive(true);
            }
        }
    }


}
