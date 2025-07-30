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
        endScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
            

            //Debug.Log("GAME OVER");
            //rb.AddForce(0, 1000, 0);

            Invoke("restartGame", restartDelay);
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
            

            //Debug.Log("Victory!!!!");
            /*rb.AddForce(0, 2000, 0);
            rb.AddTorque(0, 0, 1000);*/

            Invoke("restartGame", restartDelay);
        }
    }
}
