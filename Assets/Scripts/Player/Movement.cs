using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector2 moveInput;
    private Rigidbody2D rb;
    private float moveSpeed = 10.0f;
    private float maxSpeed = 6.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

    }

    private void FixedUpdate()
    {
        rb.AddForce(moveInput * moveSpeed);
        rb.linearVelocity = Vector2.ClampMagnitude(rb.linearVelocity, maxSpeed);
       //rb.AddForce(moveInput * moveSpeed);

    }
}
