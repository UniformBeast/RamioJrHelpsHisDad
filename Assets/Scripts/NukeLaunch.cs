using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneTemplate;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class NukeLaunch : MonoBehaviour
{


    public Animator animator;
    public float delay = 20;

 

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("End credits");
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {


        animator.SetTrigger("Launch");

        StartCoroutine(LoadLevelAfterDelay(delay));

    }
}
