using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnPauseMenuScript : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenuCanvus;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
    public void Stop()
    {
        PauseMenuCanvus.SetActive(true);
        Time.timeScale = 0f;
        Paused = true; 
    }
    public void Play()
    {
        PauseMenuCanvus.SetActive(false);
        Time.timeScale = 0f;
        Paused = false;
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
