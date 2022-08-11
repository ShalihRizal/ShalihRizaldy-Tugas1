using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    //[SerializeField]
    
    public int score;

    public TextMeshProUGUI scoretext;

    void Update()
    {
        scoretext.text = "Score : " + score.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 ray = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray, Vector2.zero);

            if(hit == null)
            {
                Debug.Log("LOL");
            }
            else
            {
                if (hit.collider.CompareTag("Zombie"))
                {
                    Destroy(hit.collider.gameObject);
                    score++;

                }else if (hit.collider.CompareTag("Human"))
                {
                    Destroy(hit.collider.gameObject);
                    GameOver();
                }
                else
                {

                }
            }
        }

    }

    void GameOver()
    {
        SceneManager.LoadScene(2);
    }

}
