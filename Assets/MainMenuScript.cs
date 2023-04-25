using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void startFunction()
    {
        SceneManager.LoadScene("Mouse_game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
