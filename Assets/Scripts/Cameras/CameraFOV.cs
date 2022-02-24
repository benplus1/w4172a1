using UnityEngine;
using UnityEngine.UI;

public class CameraFOV : MonoBehaviour
{
    float m_FieldOfView;

    void Start()
    {
        // Initialize FOV.
        m_FieldOfView = 60.0f;
    }

    void Update()
    {
        // Get the slider value for the Main Camera.
        m_FieldOfView = GameObject.Find("Canvas").transform.Find("Camera1FOV").GetComponent<Slider>().value;

        // Set the Main Camera FOV based on the slider value.
        Camera.main.fieldOfView = m_FieldOfView;
    }

}
