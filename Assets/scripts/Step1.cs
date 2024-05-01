using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1 : MonoBehaviour
{

    public GameObject basket1;
    public GameObject basket2;
    public GameObject particleSystem1;
    public GameObject particleSystem2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("player enter");
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
            // Activate step2
            if (particleSystem2 != null)
            {
                particleSystem2.SetActive(true);
            }
        }
    }
}