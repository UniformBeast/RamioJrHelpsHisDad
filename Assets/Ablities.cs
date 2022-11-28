using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ablities : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
      if(PlayerPrefs.GetInt("powertokens") >=1 )
        {
            GetComponent<PlatformerMovement>().jumpSpeed = 5.0f;




        }
    }
}
