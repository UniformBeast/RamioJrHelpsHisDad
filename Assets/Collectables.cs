using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Collectables : MonoBehaviour
{    public TextMeshProUGUI KCText;
    public int keyCard = 0;
    public int powerToken = 0;
    
    
    private void Start()
    {
        //PlayerPrefs.SetInt("keyCards", 0);
       //  PlayerPrefs.SetInt("powertokens", 0);
        KCText.text = "X " + PlayerPrefs.GetInt("keyCards");
    }

  

  
    // Update is called once per frame
    void Update()
    {
        keyCard = PlayerPrefs.GetInt("keyCards");
        powerToken = PlayerPrefs.GetInt("powertokens");

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("KeyCard"))
        {
            keyCard += 1; PlayerPrefs.SetInt("keyCards", keyCard);
            Destroy(other.gameObject);
              KCText.text = "X " + keyCard;
        }
        if (other.gameObject.CompareTag("PowerToken"))
        {
            powerToken += 1; PlayerPrefs.SetInt("powertokens", powerToken);
            Destroy(other.gameObject);
            //gemText.text = "X " + keyCard;


        }
    }

}
