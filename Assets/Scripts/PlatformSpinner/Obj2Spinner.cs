using UnityEngine;

public class Obj2Spinner : MonoBehaviour
{
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(10.0f, 15.0f);
    }

    void Update()
    {
        // Spin platform 4 object.
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
