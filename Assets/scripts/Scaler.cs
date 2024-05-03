using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scaler : MonoBehaviour
{

    public string targetTag = "flowers";
    public TextMeshProUGUI scoreText;
    public Animator animator;
    private int score = 0;
    public AudioClip audioClip;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = audioClip;
        }
        StopAnimation();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            audioSource.Play();
            score += 50;
            UpdateScoreText();
            PlayAnimation();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            score -= 50;
            UpdateScoreText();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text =  score.ToString();
    }

    private void PlayAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("PlayAnimation");
        }
    }
    private void StopAnimation()
    {
        if (animator != null)
        {
            animator.SetTrigger("StopAnimation");
        }
    }
}
