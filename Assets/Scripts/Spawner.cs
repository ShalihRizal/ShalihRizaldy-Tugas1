using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float spawnspeed;

    [SerializeField]
    int remainingzombies, wave;

    public TextMeshProUGUI wavetext, waitText;

    [SerializeField]
    private Transform[] SpawnPoints;

    [SerializeField]
    private GameObject[] Obstacles;

    public GameObject WaitPanel;

    //public Image bar;

    //float am;

    void Update()
    {
        wavetext.text = "Wave " + wave.ToString();
        //bar.fillAmount = am;
        //Debug.Log(1 / remainingzombies);
    }

    void Start()
    {
        StartCoroutine("spawn");
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(spawnspeed);
        GameObject obj = Instantiate(Obstacles[rand(0, Obstacles.Length)], SpawnPoints[rand(0, SpawnPoints.Length)].position, Quaternion.identity) as GameObject;
        //Debug.Log(obj.gameObject.tag);
        if (obj.gameObject.CompareTag("Zombie")){
            remainingzombies--;
        }
        Wave();
    }

    void Wave()
    {
        if (remainingzombies <= 0)
        {
            wave++;
            remainingzombies = wave * 6 / 2;
            spawnspeed -= 0.075f;
            //am = (float)1 / remainingzombies;
            StartCoroutine("wait");
        }

        StartCoroutine("spawn");
    }

    IEnumerator wait()
    {
        waitText.text = "Wave " + wave.ToString() + " Begin";
        WaitPanel.SetActive(true);
        yield return new WaitForSeconds(.9f);
        WaitPanel.SetActive(false);
    }

    int rand(int min, int max)
    {
        int num = Random.Range(min, max);
        return num;
    }

}
