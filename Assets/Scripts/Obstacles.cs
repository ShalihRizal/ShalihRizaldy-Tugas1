using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField]
    private float speed;

    //public Player player;

    void Awake()
    {
        //player = GameObject.Find("Main Camera").GetComponent<Player>();
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        //if(transform.position.x >= 5)
        //{
        //    player.health--;
        //}
    }

}
