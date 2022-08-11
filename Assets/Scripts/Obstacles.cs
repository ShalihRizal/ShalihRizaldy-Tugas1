using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Obstacles : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public void Check()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.width || screenPosition.y < 0)
        {
            IOutsideAble ioutside = gameObject.GetComponent<IOutsideAble>();
            ioutside.die();
        }
    }

    private void Update()
    {

    }

    public void Move()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
