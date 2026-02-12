using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotationSpeed = 120f;

    [Header("Jump")]
    [SerializeField] private float jumpForce = 6f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; // evitamos rotaciones físicas raras
    }

    void Update()
    {
        // SALTO
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); // A / D
        float v = Input.GetAxis("Vertical");   // W / S

        // ROTACIÓN PROGRESIVA
        if (Mathf.Abs(h) > 0.01f)
        {
            float rotation = h * rotationSpeed * Time.fixedDeltaTime;
            Quaternion deltaRotation = Quaternion.Euler(0f, rotation, 0f);
            rb.MoveRotation(rb.rotation * deltaRotation);
        }

        // MOVIMIENTO SOLO HACIA DELANTE
        Vector3 forwardMovement = transform.forward * v * speed;

        rb.linearVelocity = new Vector3(
            forwardMovement.x,
            rb.linearVelocity.y,
            forwardMovement.z
        );
    }

    // DETECCIÓN DE SUELO ROBUSTA
    void OnCollisionStay(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground")) return;

        foreach (ContactPoint contact in collision.contacts)
        {
            if (contact.normal.y > 0.5f)
            {
                isGrounded = true;
                return;
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
