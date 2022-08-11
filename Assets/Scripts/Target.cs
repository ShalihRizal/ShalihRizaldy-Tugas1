using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float distance = 10f;
    public float speed = 5.5f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.x += distance * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
