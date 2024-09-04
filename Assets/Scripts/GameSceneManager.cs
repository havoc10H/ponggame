using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    public void PongGame1Player() {
        SceneManager.LoadScene("PongGameScene");
    }

    public void PongGame2Players() {
        SceneManager.LoadScene("PongGameScene2");
    }

    public void NeonPongGame1Player() {
        SceneManager.LoadScene("NeonPongGameScene");
    }

    public void NeonPongGame2Players() {
        SceneManager.LoadScene("NeonPongGameScene2");
    }

    public void Bubble() {
        SceneManager.LoadScene("BubbleGameScene");
    }

    public void AirHockey() {
        SceneManager.LoadScene("AirHockeyGameScene");
    }

    public void ThreePong() {
        // CommingSoon();
        SceneManager.LoadScene("ThreePongGameScene");
    }

    public void CommingSoon() {
        SceneManager.LoadScene("CommingSoonScene");
    }
}
