using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField]
    private int health, maxhealth;

    private void Start()
    {
        health = maxhealth;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetMaxHealth()
    {
        return maxhealth;
    }

    public void SetHealth(int amount)
    {
        health = amount;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

}
