using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj1Spinner : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(10.0f, 15.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
