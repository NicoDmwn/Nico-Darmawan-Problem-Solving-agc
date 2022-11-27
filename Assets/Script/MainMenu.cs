using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Backgame()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Credit()
    {
        SceneManager.LoadScene("credit");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Nicod");
    }
}
