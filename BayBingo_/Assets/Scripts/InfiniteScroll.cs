using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{
    //adjust speed of scrolling
    //adjust whether horizontal or verical for scrolling
    [SerializeField]
    float horizontalSpeed = 0.2f;
    [SerializeField]
    float verticalSpeed = 0.2f;
    private Renderer re;
    void Start()
    {
        re = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //manages both horizontal and vertical scrolling
        Vector2 offset = new Vector2(Time.time * horizontalSpeed, Time.time * verticalSpeed);
        re.material.mainTextureOffset = offset;
    }
}
