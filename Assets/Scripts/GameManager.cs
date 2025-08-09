using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Rigidbody rb;

    public Score scoreCounter;

    public WinLoss gameStatus;

    bool gameIsRunning = true;

    public float restartDelay = 1f;

    public GameObject endScreen;

    

    void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void toCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void gameOver()
    {
        if (gameIsRunning)
        {
            gameIsRunning = false;

            scoreCounter.running = false;

            gameStatus.running = false;
            gameStatus.win = false;
            gameStatus.loss = true;

            endScreen.SetActive(true);
            
            Invoke("toCredits", restartDelay);
        }

    }

    public void gameWin()
    {
        if (gameIsRunning)
        {
            gameIsRunning = false;

            scoreCounter.running = false;

            gameStatus.running = false;
            gameStatus.loss = false;
            gameStatus.win = true;

            endScreen.SetActive(true);
            

          

            Invoke("toCredits", restartDelay);
        }
    }
}
