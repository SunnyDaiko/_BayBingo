using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    //Rows
    [SerializeField]
    public GameObject[] Row1;
    public GameObject[] Row2;
    public GameObject[] Row3;
    public GameObject[] Row4;
    //columns
    [SerializeField]
    public GameObject[] Column1;
    public GameObject[] Column2;
    public GameObject[] Column3;
    public GameObject[] Column4;
    //diagnols
    [SerializeField]
    public GameObject[] Diagnol1;
    public GameObject[] Diagnol2;
    

    public bool bingo;


    public void Update()
    {
        Bingooo();
    }
    public void Bingooo()
    {
        //Row Bingos
        Row1 = GameObject.FindGameObjectsWithTag("Correct");
        Row2 = GameObject.FindGameObjectsWithTag("Correct");
        Row3 = GameObject.FindGameObjectsWithTag("Correct");
        Row4 = GameObject.FindGameObjectsWithTag("Correct");
        //Column Bingos
        Column1 = GameObject.FindGameObjectsWithTag("Correct");
        Column2 = GameObject.FindGameObjectsWithTag("Correct");
        Column3 = GameObject.FindGameObjectsWithTag("Correct");
        Column4 = GameObject.FindGameObjectsWithTag("Correct");
        //Diagnol Bingos
        Diagnol1 = GameObject.FindGameObjectsWithTag("Correct");
        Diagnol2 = GameObject.FindGameObjectsWithTag("Correct");

        foreach (GameObject gameObject in Row1)
        {
            if (Row1.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Row2)
        {
            if (Row2.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Row3)
        {
            if (Row3.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Row4)
        {
            if (Row4.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column1)
        {
            if (Column1.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column2)
        {
            if (Column2.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column3)
        {
            if (Column3.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column4)
        {
            if (Column4.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Diagnol1)
        {
            if (Diagnol1.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Diagnol2)
        {
            if (Diagnol2.Length == 4)
            {
                bingo = true;
                Debug.Log("h2si");
            }
        }
    }
}
