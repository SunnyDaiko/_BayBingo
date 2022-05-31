using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BCTracker : MonoBehaviour
{
    public Image BGCard;
    public Sprite Correct;
    public bool right = true;
    public GameObject Lim;

    /*private void ButtonClicked()
    {
        right = false;

        if (Lim.gameObject.activeInHierarchy)
        {
            BGCard.sprite = Correct;
            right = true;
        }
    }*/
    public void Tracker()
    {
        //right = false;

        if (Lim.gameObject.activeInHierarchy)
        {
            BGCard.sprite = Correct;
            right = true;
        }

        else
        {
            right = false; 
        }
    }
}
