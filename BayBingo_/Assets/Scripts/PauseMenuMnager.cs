using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuMnager : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject PauseMenu;

    /*void Update()
    {
        if ()
        if (GameIsPause)
        {
            Resume();
        }

        else
        {
            Pause();
        }
    }*/

    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }


    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
