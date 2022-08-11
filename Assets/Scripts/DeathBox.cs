using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathBox : MonoBehaviour
{

    [SerializeField]
    int health, maxhealth = 3;
    float am;

    public TextMeshProUGUI healthtext;
    public Image heart;

    void Start()
    {
        health = maxhealth;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Zombie")
        {
            health--;
        }

    }

    void Update()
    {
        am = (float) health / maxhealth;
        heart.fillAmount = am;

        healthtext.text = "x" + health.ToString();

        if (health <= 0)
        {
            health = 0;
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
