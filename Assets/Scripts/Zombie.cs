using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Obstacles, IKillable, IOutsideAble
{
    ScoreManager scoremanager;
    HealthManager healthmanager;

    [SerializeField]
    private Sprite[] Faces;

    private void Awake()
    {
        scoremanager = GameObject.Find("Manager").GetComponent<ScoreManager>();
        healthmanager = GameObject.Find("Manager").GetComponent<HealthManager>();

        SpriteRenderer rend = gameObject.GetComponent<SpriteRenderer>();
        rend.sprite = Faces[Random.Range(0, Faces.Length)];

    }                                                                          
    private void Update()
    {
        Move();
        Check();
    }

    public void Kill()
    {
        scoremanager.addScore(1);
        Destroy(gameObject);
    }

    public void die()
    {
        healthmanager.TakeDamage(1);
        scoremanager.reduceScore(5);
        Destroy(gameObject);
    }
}
