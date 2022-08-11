using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI wavetext, waitText, scoretext, healthtext;

    [SerializeField]
    private Image heart;

    float amount;

    [SerializeField]
    private ScoreManager scoremanager;
    [SerializeField]
    private LevelManager levelmanager;
    [SerializeField]
    private HealthManager healthmanager;

    private void Update()
    {
        scoretext.text = "Score : " + scoremanager.GetScore().ToString();

        amount = (float)healthmanager.GetHealth() / healthmanager.GetMaxHealth();
        heart.fillAmount = amount;

        healthtext.text = "x" + healthmanager.GetHealth().ToString();

        if (healthmanager.GetHealth() <= 0)
        {
            healthmanager.SetHealth(0);
            levelmanager.GameOver();
        }
    }

}
