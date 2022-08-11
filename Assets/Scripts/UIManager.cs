using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI wavetext, waitText, scoretext, healthtext, remainingtext;

    [SerializeField]
    private Image heart;

    float amount;

    [SerializeField]
    private ScoreManager scoremanager;
    [SerializeField]
    private LevelManager levelmanager;
    [SerializeField]
    private HealthManager healthmanager;
    [SerializeField]
    private Spawner spawner;

    public GameObject WaitPanel;

    private void Update()
    {
        scoretext.text = "Score : " + scoremanager.GetScore().ToString();

        healthtext.text = "x" + healthmanager.GetHealth().ToString();

        remainingtext.text = "Remaining : " + spawner.GetRemainingZombies().ToString();

        amount = (float)healthmanager.GetHealth() / healthmanager.GetMaxHealth();
        heart.fillAmount = amount;

        if (healthmanager.GetHealth() <= 0)
        {
            healthmanager.SetHealth(0);
            levelmanager.GameOver();
        }
    }

    public void wait()
    {
        waitText.text = "Wave " + spawner.GetWave().ToString() + " Begin";
    }

}
