using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;  

public class PlayerInteractUI : MonoBehaviour
{

    [SerializeField] private GameObject containerGameObject;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] private TextMeshProUGUI interactTextMeshProUGUI;

    private void Update()
    {
        if (playerInteract.GetInteractableObject() != null)
        {
            Show(playerInteract.GetInteractableObject());
        }

        else
        {
            Hide();
        }
    }


    private void Show(IInteractable interactable)
    {
        containerGameObject.SetActive(true);
        interactTextMeshProUGUI.text = interactable.GetInteractText();    
    }

    private void Hide()
    {
        containerGameObject.SetActive(false);
    }

}
