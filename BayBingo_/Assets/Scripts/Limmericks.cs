using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limmericks : MonoBehaviour
{
    [SerializeField]
    public GameObject card;
    [SerializeField]
    public GameObject Lim;
    public static Limmericks instance;
    //public string newTag;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    public void Switch()
    {
        Lim.gameObject.SetActive(true);
        //gameObject.tag = newTag;
    }

    public void Bye()
    {
        Lim.gameObject.SetActive(false);
        
    }
}
