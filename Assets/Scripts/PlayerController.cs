using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public Vector3 startPosition;
    public float jumpHeight;
    public float jumpLength;
    public bool grounded;
    private Rigidbody rb;
    private bool isJumpPressed = false;
    public int lastPlatform = 1;

    public bool changedUI;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (changedUI) // If we touched the third platform.
        {
            if (Input.touchCount == 1)
            {
                Touch touch0 = Input.GetTouch(0);

                if (touch0.phase == TouchPhase.Moved) // If the touch is a swipe.
                {
                    if (!EventSystem.current.IsPointerOverGameObject()) // If no other UI elements are touched.
                    {
                        float currDirectionX = touch0.deltaPosition.x;
                        float currDirectionZ = touch0.deltaPosition.y;

                        // Rotate the player in the y direction.
                        Vector3 q = new Vector3(currDirectionX, 0f, currDirectionZ).normalized;
                        this.transform.rotation = Quaternion.LookRotation(q);
                    }

                }

            }
        }
        else // We have not reached platform 3.
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    if (!EventSystem.current.IsPointerOverGameObject(0))
                    {
                        // Check if anywhere has been pressed.
                        isJumpPressed = true;
                    }
                }
            }

            // Leftover mouse input.
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (Input.GetMouseButtonDown(0))
                {
                    isJumpPressed = true;
                }
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

    // Modify the lastPlatform based on which current platform was hit.
    // Set grounded to true when any platform is touched.
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

    // Set grounded to false when in the air.
    void OnCollisionExit(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    // Execute platform 1 & 2 UI control.
    void GotInput()
    {
        // Get ray from screen.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Set the rigidbody velocities to 0.
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        // Access the hit data.
        RaycastHit hitdata;
        bool res = Physics.Raycast(ray, out hitdata);

        // If we are grounded and we have a valid hit.
        if (res && grounded)
        {
            Vector3 hitPoint = new Vector3(hitdata.point.x, this.transform.position.y, hitdata.point.z);
            Vector3 direction = -(this.transform.position - hitPoint).normalized;
            Vector3 forceVector = (direction * jumpLength) + new Vector3(0, jumpHeight, 0);

            // Jump in the current direction and match the character to its proper rotation.
            rb.velocity = forceVector;
            this.transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}
