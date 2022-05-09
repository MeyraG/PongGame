using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text playerAIText;
    int playerScore;
    int playerAIScore;
    public BallControl ball;
    
   
    public void PlayerScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        this.ball.ResetPosition();
        
    }

    public void PlayerAIScore()
    {
        playerAIScore++;
        playerAIText.text = playerAIScore.ToString();
        this.ball.ResetPosition();
    }
}