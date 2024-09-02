using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 minBounds, maxBounds;

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePosition.x > -2.5 && mousePosition.x < 2.5) {
            if (mousePosition.y > -4.5 && mousePosition.y < 4.5) {
                transform.position = mousePosition;
            }
        }
    }
}
