using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit != null)
            {
                IKillable killable = hit.collider.GetComponent<IKillable>();
                if (killable != null)
                {
                    killable.Kill();
                }
                else
                {
                    Debug.Log("It Doesn't have an interface");
                }
            }
            else
            {
                Debug.Log("Hit something bruh");
            }

        }
    }
}
