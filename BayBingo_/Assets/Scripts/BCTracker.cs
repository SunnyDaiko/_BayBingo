using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BCTracker : MonoBehaviour
{
    public Image BGCard;
    public Sprite Correct;
    public void Tracker()
    {
        BGCard.sprite = Correct;
    }
}
