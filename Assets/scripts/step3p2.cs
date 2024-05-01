using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class step3p2 : MonoBehaviour
{
    public GameObject flower5;
    public ParticleSystem particleSystem3;
    public ParticleSystem particleSystem4;
 
    
    private void OnTriggerExit(Collider other)
    {
        if (!flower5.activeSelf)
        {
            particleSystem3.gameObject.SetActive(false);
            particleSystem4.gameObject.SetActive(true);
        }
    }
}
