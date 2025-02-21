using UnityEngine;

public class SpinningObstacle : MonoBehaviour
{
    [SerializeField]
    private Vector3 spinSpeed = Vector3.zero;

    [SerializeField]
    private Transform spinningObject;

    void FixedUpdate()
    {
        Vector3 spinAmout = spinSpeed * Time.deltaTime;
        spinningObject.Rotate(spinAmout.x, spinAmout.y, spinAmout.z);
    }
}
