xusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{
    public float scroll;
    public float scrollSpeed = 50.0f;
    public int m_PlayerNumber = 1;

    void FixedUpdate()
    {
        if (m_PlayerNumber >= 2)
        {
            var mouse = Input.mousePosition;
            var screenPoint = Camera.main.WorldToScreenPoint(transform.position);
            var offset = new Vector2(mouse.x - screenPoint.x, mouse.y - screenPoint.y);
            var angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, -angle + 145, 0);
        }

        else
        {
            scroll = Input.GetAxis("mousePosition2");
            transform.Rotate(Vector3.up * scroll * 20);
        }
    }
}
