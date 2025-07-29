using JetBrains.Annotations;
using UnityEngine;

public class playerCollision : MonoBehaviour
{


    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        

        if (collisionInfo.collider.tag == "Enemy")
        {
            movement.allowMovement=false;
            FindAnyObjectByType<GameManager>().gameOver();
        }

        if (collisionInfo.collider.tag == "goal")
        {
            movement.allowMovement=false;
            FindAnyObjectByType<GameManager>().gameWin();
        }


    }
}
