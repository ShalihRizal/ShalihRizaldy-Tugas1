using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Obstacles, IKillable, IOutsideAble
{
    ScoreManager scoremanager;
    HealthManager healthmanager;

    private void Awake()
    {
        scoremanager = GameObject.Find("Manager").GetComponent<ScoreManager>();
        healthmanager = GameObject.Find("Manager").GetComponent<HealthManager>();
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
        Destroy(gameObject);
    }
}
