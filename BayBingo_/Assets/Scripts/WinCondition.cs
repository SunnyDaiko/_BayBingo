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
    //win Animation
    public GameObject winAni;
    //int index;
    public string[] Tags;
    public GameObject fishes;
    public GameObject spawner;

    //public List<GameObject> Row_1;

    public bool bingo;


    public void Update()
    {
        R1();
        R2();
        R3();
        R4();
        C1();
        C2();
        C3();
        C4();
        D1();
        D2();
    }
    public void R1()
    {
        //GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tag);
        Row1 = GameObject.FindGameObjectsWithTag("Row1");        
        //Row1 = GameObject.FindGameObjectsWithTag("SH");
        //Row1 = GameObject.FindGameObjectsWithTag("HSC");
        /*Row2 = GameObject.FindGameObjectsWithTag("Correct");
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
        */

        {
            //GameObject.FindWithTag("BG");
            //Row1 = gameObject.GetComponentsInChildren<GameObject>();
            //GameObject.FindWithTag("LD");
            //GameObject.FindWithTag("SH");
            //GameObject.FindWithTag("HSC");

            if (Row1.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }

        /*foreach (GameObject gameObject in Row3)
        {
            if (Row3.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Row4)
        {
            if (Row4.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column1)
        {
            if (Column1.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column2)
        {
            if (Column2.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column3)
        {
            if (Column3.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Column4)
        {
            if (Column4.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Diagnol1)
        {
            if (Diagnol1.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }

        foreach (GameObject gameObject in Diagnol2)
        {
            if (Diagnol2.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("h2si");
            }
        }*/
    }

    public void R2()
    {
        Row2 = GameObject.FindGameObjectsWithTag("Row2");
        /*Row2 = GameObject.FindGameObjectsWithTag("MH");
        Row2 = GameObject.FindGameObjectsWithTag("SR");
        Row2 = GameObject.FindGameObjectsWithTag("SHE");
        foreach (GameObject gameObject in Row2)
        */
        {
            if (Row2.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void R3()
    {
        Row3 = GameObject.FindGameObjectsWithTag("Row3");
        //Row3 = GameObject.FindGameObjectsWithTag("SN");
        //Row3 = GameObject.FindGameObjectsWithTag("ST");
        //Row3 = GameObject.FindGameObjectsWithTag("CN");
        //foreach (GameObject gameObject in Row3)
        {
            if (Row3.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void R4()
    {
        Row4 = GameObject.FindGameObjectsWithTag("Row4");
        //Row4 = GameObject.FindGameObjectsWithTag("BC"); 
        //Row4 = GameObject.FindGameObjectsWithTag("BF"); 
        //Row4 = GameObject.FindGameObjectsWithTag("BS");
        //foreach (GameObject gameObject in Row4)
        {
            if (Row4.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void C1()
    {
        Column1 = GameObject.FindGameObjectsWithTag("C1");
        //Column1 = GameObject.FindGameObjectsWithTag("DF");
        //Column1 = GameObject.FindGameObjectsWithTag("FD");
        //Column1 = GameObject.FindGameObjectsWithTag("LG");
        //foreach (GameObject gameObject in Column1)
        {
            if (Column1.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void C2()
    {
        Column2 = GameObject.FindGameObjectsWithTag("C2");
        //Column2 = GameObject.FindGameObjectsWithTag("MH");
        //Column2 = GameObject.FindGameObjectsWithTag("SN");
        //Column2 = GameObject.FindGameObjectsWithTag("BC");
        //foreach (GameObject gameObject in Column2)
        {
            if (Column2.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void C3()
    {
        Column3 = GameObject.FindGameObjectsWithTag("C3");
        //Column3 = GameObject.FindGameObjectsWithTag("SR");
        //Column3 = GameObject.FindGameObjectsWithTag("ST");
        //Column3 = GameObject.FindGameObjectsWithTag("BF");
        //foreach (GameObject gameObject in Column3)
        {
            if (Column3.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void C4()
    {
        Column4 = GameObject.FindGameObjectsWithTag("C4");
        //Column4 = GameObject.FindGameObjectsWithTag("SHE");
        //Column4 = GameObject.FindGameObjectsWithTag("CN");
        //Column4 = GameObject.FindGameObjectsWithTag("BS");
        //foreach (GameObject gameObject in Column4)
        {
            if (Column4.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void D1()
    {
        Diagnol1 = GameObject.FindGameObjectsWithTag("D1");
        //Diagnol1 = GameObject.FindGameObjectsWithTag("MH");
        //Diagnol1 = GameObject.FindGameObjectsWithTag("ST");
        //Diagnol1 = GameObject.FindGameObjectsWithTag("BS");
        //foreach (GameObject gameObject in Diagnol1)
        {
            if (Diagnol1.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }

    public void D2()
    {
        Diagnol2 = GameObject.FindGameObjectsWithTag("D2");
        //Diagnol2 = GameObject.FindGameObjectsWithTag("SR");
        //Diagnol2 = GameObject.FindGameObjectsWithTag("SN");
        //Diagnol2 = GameObject.FindGameObjectsWithTag("LG");
        //foreach (GameObject gameObject in Diagnol2)
        {
            if (Diagnol2.Length == 4)
            {
                bingo = true;
                winAni.SetActive(true);
                //Time.timeScale = 0f;
                Debug.Log("h2si");
                fishes.SetActive(false);
                spawner.SetActive(false);
            }
        }
    }
}
