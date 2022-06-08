using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answers : MonoBehaviour
{
    //public string LevelToLoad;

    public void Start(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    /*public void FieldGuide(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Help(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void Settings(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }*/

    public void BackButton(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
