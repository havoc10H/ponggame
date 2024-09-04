using UnityEngine;

public class NeonPlayerPaddle2 : Paddle
{
    private Vector2 direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            direction = Vector2.left;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            direction = Vector2.right;
        } else {
            direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (direction.sqrMagnitude != 0) {
            rb.AddForce(direction * speed);
        }
    }

}
