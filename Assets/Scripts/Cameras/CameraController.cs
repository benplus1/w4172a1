using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 cameraOffset;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = target.TransformPoint(cameraOffset);
        //Debug.Log(GameObject.FindGameObjectWithTag("Player"));
        this.transform.position = player.transform.position + cameraOffset;
        //this.transform.LookAt(target);
    }

}
