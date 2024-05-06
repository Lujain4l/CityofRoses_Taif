using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;







public class backtomainscene : MonoBehaviour
{






    private IEnumerator DeactivateParticleSystemAfterDelay(float delay)
    {
        // countdown timer
        float timer = delay;
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f);
            timer -= 1f;

        }


        SceneManager.LoadScene("StartingScene");

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            StartCoroutine(DeactivateParticleSystemAfterDelay(10f));

        }
    }


    public void OnButtonClick()
    {
        SceneManager.LoadScene("StartingScene");
    }
}
