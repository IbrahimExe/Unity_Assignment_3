using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform targetToLookAt;
    public Vector3 offset;

    public Transform orientation;

    public float cameraRotationSpeed;

    float xRotation;
    float yRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetToLookAt.position + offset;

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * cameraRotationSpeed;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * cameraRotationSpeed;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90, 90);

        // Rotate Camera & Orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
