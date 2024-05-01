using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MRstartbutton : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("second");
    }
}



