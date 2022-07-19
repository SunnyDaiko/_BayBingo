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
    //[SerializeField]
    public string newTag;
    public GameObject[] Alternates;
    public static BCTracker Instance { get; private set; }
    //public Text newText;
    //public ArrayList arrayList;

    public void Start()
    {
        Instance = this;
    }

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
            //transform.gameObject.tag = "Correct";
            gameObject.tag = newTag;
            //newText.text = newTag;
            //a way to cheat unity for not adding multiple tags to a gameobject???
            foreach (GameObject gameobject in Alternates)
            {
                gameobject.SetActive(true);
            }

        }

        else
        {
            right = false;
            SoundManager.Instance.PlaySound(wrong);
            //Limmericks.instance.Bye();
            //Lim.gameObject.activeInHierarchy ;
        }

        /*if (PauseMenuMnager.GameIsPause)
        {
            GetComponent<Button>().enabled = false;
        }*/
    }

    public void KeepYellow()
    {
        Answer.color = Color.yellow;

    }

    public void Update()
    {
        if (gameObject.tag == "Correct" )
        {
            Debug.Log("gameover");
        }
    }

}
