using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ablities : MonoBehaviour
{
   public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("powertokens") >= 2)
        {
            GetComponent<PlatformerMovement>().jumpSpeed = 5.0f;

        }
         if (PlayerPrefs.GetInt("powertokens") >= 1)
        {
            GetComponent<PlatformerMovement>().moveSpeed = 5.0f;
        }
         if(PlayerPrefs.GetInt("powertokens") >= 3)
        {
            if (Input.GetMouseButtonDown(1))
            {
               animator.SetTrigger("Attack");
            }
        }
    }
}
