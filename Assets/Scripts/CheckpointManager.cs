using UnityEngine;

public class CheckpointManager : MonoBehaviour
{
    private Vector3 lastCheckpointPosition;

    void Start()
    {
        lastCheckpointPosition = transform.position;
    }

    void Update()
    {
        if (transform.position.y < - 7.5f)
        {
            Respawn();
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CP1") || other.CompareTag("CP2") || other.CompareTag("CP3") || other.CompareTag("CP4"))
        {
            lastCheckpointPosition = other.transform.position;
        }

        if (other.CompareTag("Lava"))
        {
            Respawn();
        }
    }

    // Teleport the player back to the last checkpoint
    void Respawn()
    {
        transform.position = lastCheckpointPosition;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
        }
    }
}
