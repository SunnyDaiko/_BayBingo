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
    public Image Answer;
    public Sprite CrossedOut;
    [SerializeField]
    private AudioClip wrong;
    [SerializeField]
    private AudioClip right_s;

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
            KeepYellow();
            SoundManager.Instance.PlaySound(right_s);

        }

        else
        {
            right = false;
            SoundManager.Instance.PlaySound(wrong);
        }

        /*if (PauseMenuMnager.GameIsPause)
        {
            GetComponent<Button>().enabled = false;
        }*/
    }

    public void KeepYellow()
    {
        Answer.sprite = CrossedOut;
    }
}
