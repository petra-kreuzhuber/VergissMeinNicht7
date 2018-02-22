using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour {

    //void OnTriggerEnter(Collider ChangeScene)
    //{
    //    if ()
    //    {
    //        SceneManager.LoadScene("LoadingScreen");
    //    }
    //}
   

    public void showScreen(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
        

    }
}
