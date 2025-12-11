using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;   // How strong the jump is
    public logicscript Logic;
    private Rigidbody2D rb;
    public bool birdIsAlive = true;

    void Start()
    {
        // Get the Rigidbody2D component attached to the bird
        rb = GetComponent<Rigidbody2D>();

        Logic = GameObject.FindGameObjectsWithTag("Logic")[0].GetComponent<logicscript>();
    }

    void Update()
    {
        // Check for input (spacebar or left mouse click)
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) && birdIsAlive)
        {
            Jump();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdIsAlive)
        {
            // Trigger game over
            Logic.gameover();

            // Stop the bird completely
            birdIsAlive = false;
            rb.linearVelocity = Vector2.zero;   // clear movement
            rb.isKinematic = true;        // freeze physics so it won’t fall anymore
        }
    }

    void Jump()
    {
        // Reset vertical velocity before applying jump
        rb.linearVelocity = Vector2.up * jumpForce;
    }
}
