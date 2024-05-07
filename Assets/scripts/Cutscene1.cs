using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene1 : MonoBehaviour
{
    public string tagToDestroy = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToDestroy);

            foreach (GameObject obj in objectsWithTag)
            {
                Destroy(obj);
            }
            SceneManager.LoadScene("second");
        }
    }

    public void OnButtonClick()
    {
        SceneManager.LoadScene("second");
    }
}
