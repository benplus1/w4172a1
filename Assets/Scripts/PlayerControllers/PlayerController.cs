using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    
    public Vector3 startPosition;
    public float jumpHeight;
    public float jumpLength;
    bool grounded;
    private Rigidbody rb;
    private bool isJumpPressed = false;
    public int lastPlatform = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            //touch is valid
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    isJumpPressed = true;
                }
            }
        }

        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (Input.GetMouseButtonDown(0))
            {
                isJumpPressed = true;
            }
        }

    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {
            GotInput();
            isJumpPressed = false;
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            grounded = true;

            if (hit.gameObject.name == "Plane_2")
            {
                lastPlatform = 2;
            }
            if (hit.gameObject.name == "Plane_3")
            {
                lastPlatform = 3;
            }
            if (hit.gameObject.name == "Plane_42")
            {
                lastPlatform = 4;
            }
            else if (hit.gameObject.name == "Plane_1")
            {
                lastPlatform = 1;
            }
        }
    }

    // Detect collision exit with floor
    void OnCollisionExit(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    void GotInput()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        RaycastHit hitdata;
        bool res = Physics.Raycast(ray, out hitdata);

        if (res && grounded)
        {
            Vector3 hitPoint = new Vector3(hitdata.point.x, this.transform.position.y, hitdata.point.z);
            Vector3 direction = -(this.transform.position - hitPoint).normalized;
            Vector3 forceVector = (direction * jumpLength) + new Vector3(0, jumpHeight, 0);
            rb.velocity = forceVector;
            this.transform.rotation = Quaternion.LookRotation(direction);
            
        }
    }
}
