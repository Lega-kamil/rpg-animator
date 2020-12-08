using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    Animator animator;
    
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

   
    void Update()
    {
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Jump();
        }

    }
    public void Jump()
    {
        animator.SetTrigger("jump");
    }
}
