using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HockeyGameManager : MonoBehaviour
{
    public int playerScore = 0;
    public int computerScore = 0;
    public Transform ball;
    public Transform computerCharacter;

    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text computerScoreText;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ResetBallPosition();
        ResetComputerCharacterPosition();
        // Update UI or announce score
    }

    public void ComputerScores()
    {
        computerScore++;
        computerScoreText.text = computerScore.ToString();
        ResetBallPosition();
        ResetComputerCharacterPosition();
    }

    public void ResetBallPosition()
    {
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.zero;
        rb.position = Vector2.zero;
    }

    public void ResetComputerCharacterPosition() 
    {
        computerCharacter.position = new Vector2(0f, 4.5f);
    }
}
