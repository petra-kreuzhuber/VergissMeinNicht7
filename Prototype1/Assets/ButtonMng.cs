using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ButtonMng : MonoBehaviour
{

	public void newGame(string newGameLevel)
    {
        SceneManager.LoadScene(newGameLevel);
    }
}
