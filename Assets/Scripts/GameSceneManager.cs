using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{

    public void PongGameComPlay() {
        SceneManager.LoadScene("PongGameScene");
    }

    public void PongGameTwoPlay() {
        SceneManager.LoadScene("PongGameScene2");
    }

    public void BubbleGame() {
        SceneManager.LoadScene("BubbleGameScene");
    }
}
