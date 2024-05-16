using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
   
    public float delay = 3f;

    
    void Start()
    {
        
        StartCoroutine(WaitAndLoadScene());
    }

    IEnumerator WaitAndLoadScene()
    {
        
        yield return new WaitForSeconds(delay);

       
        SceneManager.LoadScene("Goals");
    }
}
