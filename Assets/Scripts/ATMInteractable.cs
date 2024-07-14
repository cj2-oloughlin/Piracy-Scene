using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMInteractable : MonoBehaviour, IInteractable
{
    private Animator animator;
    private bool isActive;
    public AudioClip atmSFX;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void React()
    {
        isActive = !isActive;
        animator.SetBool("isActive", isActive);
        gameObject.GetComponent<AudioSource>().PlayOneShot(atmSFX);
    }

    public void Interact(Transform interactorTransform)
    {
        React();
    }

    public string GetInteractText()
    {
        return "Shake ATM";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
