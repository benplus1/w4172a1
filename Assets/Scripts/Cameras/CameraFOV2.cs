using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFOV2 : MonoBehaviour
{
    float m_FieldOfView;

    void Start()
    {
        // Initialize FOV.
        m_FieldOfView = 60.0f;
    }

    void Update()
    {
        // Get the slider value for the Platform Camera.
        Camera cam = GameObject.Find("Platform Camera").GetComponent<Camera>();
        m_FieldOfView = GameObject.Find("Canvas").transform.Find("Camera2FOV").GetComponent<Slider>().value;

        // Set the Platform Camera FOV based on the slider value.
        cam.fieldOfView = m_FieldOfView;
    }
}
