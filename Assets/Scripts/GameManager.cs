using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playerScore;
    int playerAIScore;
    public BallControl ball;
   
    public void PlayerScore()
    {
        playerScore++;
        Debug.Log(playerScore);
        this.ball.ResetPosition();
    }

    public void PlayerAIScore()
    {
        playerAIScore++;
        Debug.Log(playerAIScore);
        this.ball.ResetPosition();
    }
}
