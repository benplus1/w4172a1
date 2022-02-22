using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 cameraOffset;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        cameraOffset = this.transform.position - GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = target.TransformPoint(cameraOffset);
        this.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position + cameraOffset;
        //this.transform.LookAt(target);
    }

}
