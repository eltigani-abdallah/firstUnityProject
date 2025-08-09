using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    
    public void start() {
        
        SceneManager.LoadScene("Gameplay");
    }

    public void quit()
    {
        
        Application.Quit();
        
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
