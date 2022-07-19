using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDelay : MonoBehaviour
{
    public float runningTime = 3f;
    public float delay = 0f;
    public GameObject[] text;
    void Update()
    {
        delay += Time.deltaTime;
        if (delay > runningTime)
        {
            //delay = 0f;
            foreach (GameObject gameObject in text)
            gameObject.SetActive(true);
        }

        /*if (delay > 5)
        {
            Time.timeScale = 0f;
            delay = 0f;
            /*foreach (GameObject gameObject in text)
            gameObject.SetActive(true);
            
        }*/
    }
}
