using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject PauseMenuCanvus;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("if statement Hit");
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

    }
    public void PauseGame()
    {
        
        if (gameIsPaused)
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            PauseMenuCanvus.SetActive(true);
        }
        else
        {
            
            Cursor.visible = false;
            Time.timeScale = 1;
            PauseMenuCanvus.SetActive(false);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void Play()
    {
        PauseMenuCanvus.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
