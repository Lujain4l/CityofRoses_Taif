using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MRstartbutton : MonoBehaviour
{
    public string tagToDestroy = "AR";
    public void OnButtonClick()
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tagToDestroy);

        foreach (GameObject obj in objectsWithTag)
        {
            Destroy(obj);
        }
        SceneManager.LoadScene("CarScene");
    }
}



