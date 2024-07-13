using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{

    public Animator animator;

    void Start()
    {
        
    }

    void Update()
    {
        //whisper should occur whenever the player presses 'E'
        //run, sneak and yell takes place over a cutscene

        if(Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("whisper");
        }
    }
}
