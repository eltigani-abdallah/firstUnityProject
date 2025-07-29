using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public bool running;

    void Start()
    {
       running = true;
    }
    // Update is called once per frame
    void Update()
    {
        string playerScore = player.position.z.ToString("0");
        if (running==true)
        {
            scoreText.text =playerScore;
        }
    }
}
