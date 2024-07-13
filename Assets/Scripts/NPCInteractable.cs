using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private string interactText;
    [SerializeField] private Dialogue dialogue;

    

    public void Interact()
    {
        Debug.Log("Interact!");
        dialogue.Talk();
    }

    public string GetInteractText()
    {
        return interactText;
    }

}
