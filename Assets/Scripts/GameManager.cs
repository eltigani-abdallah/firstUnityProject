using UnityEngine;


public class GameManager : MonoBehaviour
{
    public Rigidbody rb;
    public Score scoreCounter;
    public WinLoss gameStatus;
    public void gameOver()
    {
        scoreCounter.running = false;

        gameStatus.running = false;
        gameStatus.win = false;
        gameStatus.loss = true;

        Debug.Log("GAME OVER");
        rb.AddForce(0, 1000, 0);

    }

    public void gameWin()
    {
        scoreCounter.running = false;

        gameStatus.running=false;
        gameStatus.loss = false;
        gameStatus.win = true;

        Debug.Log("Victory!!!!");
        rb.AddForce(0, 2000, 0);
        rb.AddTorque(0, 0, 1000);
    }
}
