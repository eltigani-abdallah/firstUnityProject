using TMPro;
using UnityEngine;

public class WinLoss : MonoBehaviour
{
    public TextMeshProUGUI statusText;

    public bool win;
    public bool loss;
    public bool running;

    void Start()
    {
        win = false;
        loss = false;
        running = true;
    }

    
    void Update()
    {
     
        if (running)
        {
            statusText.text = " ";
        }

        if (win)
        {
            statusText.text = "VICTORY!!!";
        }

        if (loss)
        {
            statusText.text = "GAME OVER";
        }
    }
}
