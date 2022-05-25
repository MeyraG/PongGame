using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text playerScoreText;
    public Text playerAIText;
    public Text gameOverText;
    int playerScore;
    int playerAIScore;
    public BallControl ball;
    public BallControl ballControl;
    public int totalRound;
    public int currentRound;
    public bool isPlaying;

    private void Start()
    {
        ballControl = GameObject.FindGameObjectWithTag("BallControl").GetComponent<BallControl>();
    }
    public void RoundOver()
    {
        isPlaying = false;

        if (currentRound >= totalRound)
        {
            GameOver();
        }
        else
        {
            Invoke("NewRound", 1.2f);
        }
    }

    public void GameOver()
    {
        currentRound = 0;
        gameOverText.gameObject.SetActive(true);

        if (playerAIScore > playerScore)
        {
            gameOverText.text = "The Winner is Computer";
        }
        else
        {
            gameOverText.text = " You Won! ";
        }

        Time.timeScale = 0f;
        Debug.Log("game over is working");
    }

    public void NewRound()
    {
        Debug.Log("New round is working");
        currentRound++;
        RestartLevel();
    }

    public void RestartLevel()
    {
        isPlaying = true;
        FindObjectOfType<PlayerControl>().ResetPosPlayer();
        FindObjectOfType<PlayerAI>().ResetPosAI();
    }

    void ResetScore()
    {
        Debug.Log("ResetScore is working");
        playerAIScore = 0;
        playerScore = 0;
        playerScoreText.text = playerScore.ToString();
        playerAIText.text = playerAIScore.ToString();
    }

    public void Replay()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Replay is working");
            ResetScore();
            RestartLevel();
            gameOverText.gameObject.SetActive(false);
        }
    }
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
    private void Update()
    {
        Replay();
    }
}