using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform respawnPoint;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Respawn()
    {
        transform.position = respawnPoint.position;

        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}