using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class step3 : MonoBehaviour
{
    public GameObject canvas; 
    public float displayDuration = 4f; 

    private IEnumerator Startt()
    {
       
        canvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(displayDuration);
        canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Startt()); 
            StartCoroutine(LoadNextScene()); 
        }
    }

    private IEnumerator LoadNextScene()
    {
        yield return new WaitForSeconds(displayDuration); 
        SceneManager.LoadScene("cook");
    }
}

