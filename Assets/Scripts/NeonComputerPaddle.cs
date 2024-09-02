using UnityEngine;

public class NeonComputerPaddle : Paddle
{
    [SerializeField]
    private Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.y > 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (ball.position.x > rb.position.x) {
                rb.AddForce(Vector2.right * speed);
            } else if (ball.position.x < rb.position.x) {
                rb.AddForce(Vector2.left * speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (rb.position.x > 0f) {
                rb.AddForce(Vector2.right * speed);
            } else if (rb.position.x < 0f) {
                rb.AddForce(Vector2.left * speed);
            }
        }
    }

}
