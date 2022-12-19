using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
         if (health <= 0)
        {
            SceneManager.LoadScene("death");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "Enemy" && gameObject.layer != LayerMask.NameToLayer("Whip"))
        {
            Debug.Log("Die");
            health--;
            slider.value = health;
            
        }
      
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spike")
        {
            health--;
            slider.value = health;
        }
    }
}
