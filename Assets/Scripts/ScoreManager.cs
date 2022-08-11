using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    private int score = 0;

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int amount)
    {
        score = amount;
    }

    public void addScore(int amount)
    {
        score = score += amount;
    }

    public void reduceScore(int amount)
    {
        score = score -= amount;
    }

    private void Update()
    {
        if(score <= 0)
        {
            score = 0;
        }
    }
}
