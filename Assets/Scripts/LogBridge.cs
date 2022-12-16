using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogBridge : MonoBehaviour
{
    
    public Animator animator;

    
     private void OnTriggerStay2D(Collider2D collision)
     {
        if (Input.GetKeyDown(KeyCode.P))
         {
            animator.SetTrigger("Log");

         }

     }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("LogShwoom");

        }
    }

    

}
