using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CringeZombie : MonoBehaviour, IOutsideAble, IKillable
{
    Transform target;

    HealthManager healthmanager;
    ScoreManager scoremanager;

    [SerializeField]
    float movspeed;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Target").transform;
        healthmanager = GameObject.Find("Manager").GetComponent<HealthManager>();
        scoremanager = GameObject.Find("Manager").GetComponent<ScoreManager>();
    }

    public void Update()
    {
        if (target)
        {
            Vector2 direction = (target.position - transform.position);
            transform.position = Vector2.MoveTowards(transform.position, direction, movspeed * Time.deltaTime);
        }
    }

    public void die()
    {
        healthmanager.TakeDamage(1);
        Destroy(gameObject);
    }

    public void Kill()
    {
        scoremanager.addScore(2);
        Destroy(gameObject);
    }
}
