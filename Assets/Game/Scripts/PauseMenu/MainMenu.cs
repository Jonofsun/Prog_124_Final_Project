using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Exits");
    }
}
