using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Gem : MonoBehaviour
{
    private void Start()
    {
      gemText.text = "X " + gemValue;
    }

    public int gemValue = 0;
    public TextMeshProUGUI gemText;
    // Update is called once per frame
    void Update()
    {
        gemValue = PlayerPrefs.GetInt("Gem");
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("Gems"))
        {
            gemValue += 1; PlayerPrefs.SetInt("gemValue", gemValue);
            Destroy(other.gameObject);
            gemText.text = "X " + gemValue;
        }
    }

}
