using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
    [SerializeField]
    float speed = 0f;
    [SerializeField]
    public Transform target;
    public float t;
    
    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(32f, transform.position.y), 1f * speed * Time.deltaTime);

        Vector2 a = transform.position;
        Vector2 b = target.position;
        transform.position = Vector2.MoveTowards(a, Vector2.Lerp(a, b, t), speed);
    }
}
