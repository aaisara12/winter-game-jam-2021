using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ControlsMenu()
    {
        SceneManager.LoadScene("Controls");
    }

    public void showCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Home");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
