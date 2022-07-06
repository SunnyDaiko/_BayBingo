using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FGSwitch : MonoBehaviour
{
    public GameObject[] background;
    int index;

    void Start()
    {
        index = 0;
    }


    void Update()
    {
        if (index >= 16)
            index = 0;

        if (index < 0)
            index = 0;



        if (index == 0)
        {
            background[0].gameObject.SetActive(true);
        }

    }

    public void Next()
    {
        index += 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);

        //if (index > 17)
            
    }

    public void Previous()
    {
        index -= 1;

        for (int i = 0; i < background.Length; i++)
        {
            background[i].gameObject.SetActive(false);
            background[index].gameObject.SetActive(true);
        }
        Debug.Log(index);
    }
}
