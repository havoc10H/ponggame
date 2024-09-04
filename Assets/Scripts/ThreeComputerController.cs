using UnityEngine;

public class ThreeComputerController : MonoBehaviour
{
    public Transform ball;
    public float speed = 8f;
    public float reactionTime = 0.5f;  // Delay before the computer reacts

    private Vector3 targetPosition;

    void Update()
    {
        MoveTowardsBall();
    }

    void MoveTowardsBall()
    {
        // Only move the paddle when the ball is on the computer's side
        if (ball.position.z > 0)
        {
            targetPosition = new Vector3(ball.position.x, transform.position.y, transform.position.z);
        }

        // Move the paddle towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
