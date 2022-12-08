using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("A1"))
        {
            SceneManager.LoadScene("Level1A");
        }
        if (collision.gameObject.CompareTag("A2"))
        {
            SceneManager.LoadScene("Level2A");
        }
        if (collision.gameObject.CompareTag("A3"))
        {
            SceneManager.LoadScene("Level3A");
        }
    }
}
