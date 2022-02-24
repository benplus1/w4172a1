using UnityEngine;

public class Cylinder1Controller : MonoBehaviour
{
    private float rotationSpeed;

    void Start()
    {
        // Initialize Cylinder rotation speed on platform 2.
        rotationSpeed = Random.Range(10.0f, 15.0f);
    }

    void Update()
    {
        // Rotate cylinder with respect to change in time.
        transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
    }
}
