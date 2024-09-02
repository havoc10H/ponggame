using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComCharacterController : MonoBehaviour
{
    public Transform ball;
    public Transform playerHome;
    public float speed = 0.01f;
    public float pushDistance = 0.5f; // Distance at which the computer will push the ball
   public float offset = 0.8f;
   public float pushForce = 1f; // Separate variable for pushing force
    private Rigidbody2D ballRb;

    void Start()
    {
        ballRb = ball.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
         Vector2 targetPosition = new Vector2(ball.position.x, ball.position.y);
        targetPosition += (targetPosition - (Vector2)transform.position).normalized * offset;

        float step = speed * Time.deltaTime;
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, step);

        float distanceToBall = Vector2.Distance(transform.position, ball.position);

        if (distanceToBall < pushDistance)
        {
            Vector2 pushDirection = (playerHome.position - ball.position).normalized;
            ballRb.AddForce(pushDirection * pushForce, ForceMode2D.Impulse);
        }
    }
}
