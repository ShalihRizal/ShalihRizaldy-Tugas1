using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float spawnspeed;

    [SerializeField]
    int remainingzombies, wave;

    public TextMeshProUGUI wavetext;

    public float lifespan;

    [SerializeField]
    private Transform[] SpawnPoints;

    [SerializeField]
    private GameObject[] Obstacles;
    
    void Update()
    {
        wavetext.text = "Wave " + wave.ToString();
    }

    void Start()
    {
        InvokeRepeating("spawn", 0, spawnspeed);
    }

    void spawn()
    {
          GameObject obj = Instantiate(Obstacles[Random.Range(0, Obstacles.Length)], SpawnPoints[Random.Range(0, SpawnPoints.Length -1)].position, Quaternion.identity) as GameObject;
        Destroy(obj, lifespan);
        Wave();
    }

    void Wave()
    {
        remainingzombies--;

        if (remainingzombies <= 0)
        {
            wave++;
            remainingzombies = wave * 6 / 2;
            spawnspeed -= 0.05f;
        }
    }

    //int rand(int min, int max)
    //{
    // int num = Random.Range(min, max);
    //return num;
    //}

}
