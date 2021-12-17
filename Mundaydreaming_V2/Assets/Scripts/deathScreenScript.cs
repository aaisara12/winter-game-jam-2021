using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathScreenScript : MonoBehaviour
{
    //dummy change
    public void setDead()
    {
        gameObject.SetActive(true);
    }
    public void restart()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
        SceneManager.LoadScene("Main");
    }
    
}
