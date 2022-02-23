using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFOV : MonoBehaviour
{
    //This is the field of view that the Camera has
    float m_FieldOfView;

    void Start()
    {
        //Start the Camera field of view at 60
        m_FieldOfView = 60.0f;
    }

    void Update()
    {
        //Update the camera's field of view to be the variable returning from the Slider
        m_FieldOfView = GameObject.Find("Canvas").transform.Find("Camera1FOV").GetComponent<Slider>().value;
        Camera.main.fieldOfView = m_FieldOfView;
    }

}
