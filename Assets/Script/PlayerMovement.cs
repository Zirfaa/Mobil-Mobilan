using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]private float moveSpeed = 5f;
    [SerializeField]private float turnSpeed = 160f;
    private float moveDirection = 0f;
    private float turnDirection = 0f;
    
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        turnDirection = Input.GetAxis("Horizontal");
        moveDirection = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + (Vector2)transform.up * moveDirection * moveSpeed * Time.fixedDeltaTime);
        rb.MoveRotation(rb.rotation - turnDirection * turnSpeed * Time.deltaTime);
    }
}
