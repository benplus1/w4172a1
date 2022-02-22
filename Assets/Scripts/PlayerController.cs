using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    
    private Vector3 startPosition;
    public Button GunButton;
    public GameObject canvas;
    public float jumpHeight;
    public float jumpLength;
    bool grounded;
    Vector3 movement;
    Camera cam;
    private Rigidbody rb;
    private ProjectileGroupController groupControllerScript;
    private bool isJumpPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        startPosition = this.transform.position;
        cam = GetComponent<Camera>();
        Button gunButtonComponent = GunButton.GetComponent<Button>();
        gunButtonComponent.onClick.AddListener(Shoot);
        groupControllerScript = GameObject.Find("ProjectileGroup").GetComponent<ProjectileGroupController>();
    }

    void Shoot()
    {
        GameObject projectileGroup = GameObject.Find("ProjectileGroup");
        projectileGroup.GetComponent<ProjectileGroupController>().CreateNewProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                isJumpPressed = true;
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            isJumpPressed = true;
        }
    }

    void FixedUpdate()
    {
        if (isJumpPressed)
        {
            // the cube is going to move upwards in 10 units per second
            GotInput();
            isJumpPressed = false;

        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Ground")
        {
            grounded = true;
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

        RaycastHit hitdata;
        bool res = Physics.Raycast(ray, out hitdata);

        if (res && grounded)
        {
            Vector3 hitPoint = new Vector3(hitdata.point.x, this.transform.position.y, hitdata.point.z);
            Vector3 direction = -(this.transform.position - hitPoint).normalized;
            Vector3 forceVector = (direction * jumpLength) + new Vector3(0, jumpHeight, 0);
            //rb.AddForce(forceVector);
            rb.velocity = forceVector;
            //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), Time.deltaTime * 40f);
            this.transform.rotation = Quaternion.LookRotation(direction);
        }
    }

    //}
    //Coroutine coroutine;
    //public Material RedMat;
    //public Material originalMat;
    //public void Hit()
    //{
    //    if (coroutine != null)
    //        StopCoroutine(coroutine);

    //    StartCoroutine(changeColorForSeconds(0.2f));
    //}

    //IEnumerator changeColorForSeconds(float seconds)
    //{
    //    GetComponent<MeshRenderer>().material = RedMat;
    //    yield return new WaitForSeconds(seconds);
    //    GetComponent<MeshRenderer>().material = originalMat;
    //}
}
