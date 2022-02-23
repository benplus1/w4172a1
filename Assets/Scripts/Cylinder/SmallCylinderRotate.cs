using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCylinderRotate : MonoBehaviour
{
    // Start is called before the first frame update
    private float rotationSpeed;

    void Start()
    {
        rotationSpeed = Random.Range(30.0f, 50.0f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
