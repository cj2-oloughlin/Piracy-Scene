using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteractable : MonoBehaviour, IInteractable
{
    private Animator animator;
    private bool isOpen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleBox()
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleBox();
    }

    public string GetInteractText()
    {
        return "Open/Close box";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
