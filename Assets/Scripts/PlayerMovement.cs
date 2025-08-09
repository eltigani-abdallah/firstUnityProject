using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody rb;
    public float forwardForce;
    public float moveForce;
    public float jumpForce;
    public bool allowMovement;







    void Start()
    {

        allowMovement = true;
    }



    // Update is called once per frame
    void FixedUpdate()
    {

        

        if (allowMovement == true)
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);


            if (Input.GetKey("a"))
            {
                rb.AddForce(-moveForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("d"))
            {
                rb.AddForce(moveForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -moveForce * Time.deltaTime, ForceMode.VelocityChange);
            }

            if (rb.position.y < 0)
            {
                allowMovement = false;
                FindAnyObjectByType<GameManager>().gameOver();
            }
        }
        
    }
}
