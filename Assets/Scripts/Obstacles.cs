using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]
    private float speed;

    void Awake()
    {
        //player = GameObject.Find("Main Camera").GetComponent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("DeathBox"))
        {
            Destroy(gameObject);

            if (gameObject.CompareTag("Human"))
            {

            }
        }
    }

    void OnDestroy()
    {
        //Debug.Log("Its a Zombie");
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        //if (transform.position.x >= -5)
        //{
        //    Debug.Log("Its Should be dead alr");
        //}
    }

}
