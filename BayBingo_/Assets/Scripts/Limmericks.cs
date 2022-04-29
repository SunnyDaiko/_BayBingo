using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limmericks : MonoBehaviour
{
    [SerializeField]
    public GameObject card;
    [SerializeField]
    public GameObject Lim;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Switch()
    {
        Lim.gameObject.SetActive(true);
    }

    public void Bye()
    {
        Lim.gameObject.SetActive(false);
    }
}
