using UnityEngine;
using UnityEngine.UI;

public class ThreeGameManager : MonoBehaviour
{
    public ThreeBallController ballController;
    public Transform playerPaddle;
    public Transform computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;
    public Button restartButton;

    private int playerScore = 0;
    private int computerScore = 0;

    void Start()
    {
        restartButton.onClick.AddListener(RestartGame);
    }

    void Update()
    {
        CheckForScore();
    }

    void CheckForScore()
    {
        if (ballController.transform.position.z > computerPaddle.position.z + 1)
        {
            playerScore++;
            UpdateScoreUI();
            ResetBall();
        }
        else if (ballController.transform.position.z < playerPaddle.position.z - 1)
        {
            computerScore++;
            UpdateScoreUI();
            ResetBall();
        }
    }

    void UpdateScoreUI()
    {
 //       playerScoreText.text = "Player: " + playerScore;
   //     computerScoreText.text = "Computer: " + computerScore;
    }

    void ResetBall()
    {
        ballController.transform.position = Vector3.zero;
        ballController.ServeBall();
    }

    void RestartGame()
    {
        playerScore = 0;
        computerScore = 0;
        UpdateScoreUI();
        ResetBall();
    }
}
