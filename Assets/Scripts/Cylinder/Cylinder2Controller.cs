using UnityEngine;

public class Cylinder2Controller : MonoBehaviour
{
    private float rotationSpeed;

    void Start()
    {
        // Initialize Cylinder rotation speed on platform 2.
        rotationSpeed = Random.Range(10.0f, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate cylinder with respect to change in time.
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
