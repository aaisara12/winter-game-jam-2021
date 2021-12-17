using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
   
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        
    }

    public void Resume()
    {
       Time.timeScale = 1f;
       GameIsPaused = false;
       pauseMenuUI.SetActive(false);
    }

    void Pause()
    {
       Time.timeScale = 0f;
       GameIsPaused = true;
       pauseMenuUI.SetActive(true);

    }

    public void retMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Home");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
