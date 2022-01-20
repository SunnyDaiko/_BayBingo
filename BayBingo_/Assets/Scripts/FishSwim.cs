using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    [SerializeField]
    float speed = 0f;
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(32f, transform.position.y), 1f * speed * Time.deltaTime);
    }
}
