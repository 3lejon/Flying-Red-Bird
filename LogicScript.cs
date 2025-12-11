using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    void Start()
    {
        // Hide the game over screen at the start
        gameOverScreen.SetActive(false);
    }

    [ContextMenu("increase Score")] 
    public void addscore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        // Show the game over screen when the game ends
        gameOverScreen.SetActive(true);
    }
}


