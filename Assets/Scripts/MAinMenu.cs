using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAinMenu : MonoBehaviour
{

   public void Play()
    {
        SceneManager.LoadScene("FirstScene");
    }
    
   public void Quit()
    {

        Application.Quit();


    }






  
}
