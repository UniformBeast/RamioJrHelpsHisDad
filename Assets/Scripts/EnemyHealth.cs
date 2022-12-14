using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    public int health = 2;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Whip"))
        {
            if (collision.collider.gameObject.layer != LayerMask.NameToLayer("Player"))
            {
                Debug.Log("Hit");
                health--;
                slider.value = health;
            }
        }



    }

}
