using UnityEngine;

public class MovingPlatformClase : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    private Rigidbody rb;
    private Vector3 target;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("La plataforma necesita un Rigidbody");
        }
    }

    void Start()
    {
        if (pointA != null && pointB != null)
        {
            target = pointB.position;
        }
    }

    void FixedUpdate()
    {
        if (rb == null || pointA == null || pointB == null)
            return;

        Vector3 newPosition = Vector3.MoveTowards(rb.position, target, speed * Time.fixedDeltaTime);

        rb.MovePosition(newPosition);

        if (Vector3.Distance(rb.position, target) < 0.1f)
        {
            if (target == pointA.position)
            {
                target = pointB.position;
            }
            else
            {
                target = pointA.position;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}