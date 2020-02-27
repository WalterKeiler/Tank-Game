using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotate : MonoBehaviour
{
    public int m_PlayerNumber = 1;
    public float scroll;
    public float scrollSpeed = 50.0f;
    public float top = 330f;
    public float bottom = 355f;


    void Start()
    {
        scroll = Input.GetAxis("Scroll" + m_PlayerNumber);
    }

    void Update()
    {

        if (m_PlayerNumber <= 1)
        {
            scroll = Input.GetAxis("Scroll1");
            transform.Rotate(Vector3.left * scroll * 1);
        }
        else
        {
            scroll = Input.GetAxis("Scroll2");
            transform.Rotate(Vector3.left * scroll * scrollSpeed);
        }

        bool InBetween = false;
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        //Debug.Log("CURRENT ROTATION: " + currentRotation.ToString());

        // Because this is wrapping rotation, I have 2 positive values
        if (currentRotation.x > top && currentRotation.x <= 360.0f || currentRotation.x >= 360 && currentRotation.x <= bottom)
        {
            InBetween = true;
        }
        else
        {
            InBetween = false;
        }
        // if its outside the range you want, force it back to the closest value within the range and set the rotation via transform.localRotation
        if (!InBetween)
        {
            // Closer to 40
            if (Mathf.Abs(currentRotation.x - top) > Mathf.Abs(currentRotation.x - 40))
            {
                currentRotation.x = bottom;
                transform.localRotation = Quaternion.Euler(currentRotation);
                InBetween = true;
            }
            // Closer to 320
            else if (Mathf.Abs(currentRotation.x - bottom) > Mathf.Abs(currentRotation.x - top))
            {
                currentRotation.x = top;
                transform.localRotation = Quaternion.Euler(currentRotation);
                InBetween = true;
            }
        }
    }
}


