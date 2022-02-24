using UnityEngine;

public class SmallCylinderRotate : MonoBehaviour
{
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(30.0f, 50.0f);
    }

    void Update()
    {
        // Rotate small cylinders with respect to time.
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
