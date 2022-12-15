using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogBridge : MonoBehaviour
{
    
    Animator animator;
   
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Log" & Input.GetKeyDown("p"))
        {
            animator.SetTrigger("Log");
        }
    }





}
