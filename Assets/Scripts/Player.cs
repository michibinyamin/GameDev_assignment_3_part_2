using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using System.Collections;

public class Player : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    private PlayerInput playerInput;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1f);  // Ground check
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        //Debug.Log(isGrounded);
        if (context.performed)
        {
            Debug.Log("Jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);  // Apply jump force
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HIT!");
        if (other.CompareTag("Obstacle"))
        {
            Debug.Log("HIT!");
            Destroy(gameObject);
            //Ground.gameSpeed = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //StartCoroutine(ReloadScene(4));        
        }
    }
    private IEnumerator ReloadScene(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
