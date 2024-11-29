using UnityEngine;

public class DinoJump : MonoBehaviour
{
    //public float jumpForce = 15f; // Adjust the force as needed
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component
        InvokeRepeating("Jump", 0f, 3f); // Call Jump method every 2 seconds
    }

    void Jump()
    {
        if (rb != null)
        {
            float jumpForce = Random.Range(4f, 10f);
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce); // Apply jump force
        }
    }

    void Update()
    {
        // Keep the y-position clamped within bounds
        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, 0, 14);
        transform.position = clampedPosition;
    }
}
