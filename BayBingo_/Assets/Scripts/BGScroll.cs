using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    [SerializeField]
    public float speed = 4f;
    private Vector3 start;

    void Start()
    {
        //starting position for background
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       //moves background image
        transform.Translate(translation: Vector3.left * speed * Time.deltaTime);
        //creates looping effect
        //-18.2f is where the gap starts between each background
        /*if (transform.position.y > 22.2f)
        {
            //resets the position of the bg to create the looping effect
            transform.position = start;
        }*/

    }
}
