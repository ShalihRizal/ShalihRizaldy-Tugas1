using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Zombie")
        {
            Destroy(other.gameObject);
        }

    }
}
