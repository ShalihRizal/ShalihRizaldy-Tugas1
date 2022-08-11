using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Human : Obstacles, IKillable, IOutsideAble
{
    private ScoreManager scoremanager;

    private void Awake()
    {
        scoremanager = GameObject.Find("Manager").GetComponent<ScoreManager>();
    }

    private void Update()
    {
        Move();
        Check();
    }

    public void Kill()
    {
        SceneManager.LoadScene(2);
    }

    public void die()
    {
        scoremanager.addScore(3);
        Destroy(gameObject);
    }
}
