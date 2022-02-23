using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj2Spinner : MonoBehaviour
{
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(10.0f, 15.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
