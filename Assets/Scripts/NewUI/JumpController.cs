using UnityEngine;
using UnityEngine.UI;

public class JumpController : MonoBehaviour
{
    public GameObject player2;
    public GameObject player;
    public Button newJumpButton;
    public JumpButton jbc;
    public float jumpHeight;
    public float jumpLength;
    Rigidbody rb;

    public Button upButton;
    public UpButton ubc;
    public Button rightButton;
    public DownButton dbc;
    public Button downButton;
    public RightButton rbc;
    public Button leftButton;
    public LeftButton lbc;

    PlayerController pbc;

    void Start()
    {
        jbc = newJumpButton.GetComponent<JumpButton>();
        ubc = upButton.GetComponent<UpButton>();
        lbc = leftButton.GetComponent<LeftButton>();
        rbc = rightButton.GetComponent<RightButton>();
        dbc = downButton.GetComponent<DownButton>();

        rb = player2.GetComponent<Rigidbody>();
        pbc = player2.GetComponent<PlayerController>();
    }

    void Update()
    {
        if (pbc.grounded) // If the player is grounded.
        {
            if (jbc.isPressed) // If the jump button is pressed.
            {
                Vector3 jumpVector = new Vector3(0, jumpHeight, 0);
                Vector3 forceVector = new Vector3(0, 0, 0);

                // Check if corresponding DPAD button is pressed and add velocity.
                if (ubc.isPressed)
                {
                    Vector3 direction = player2.transform.forward.normalized;
                    forceVector = (direction * jumpLength);

                }
                if (rbc.isPressed)
                {
                    Vector3 fwd = player2.transform.forward.normalized;
                    Vector3 direction = new Vector3(fwd.z, fwd.y, -fwd.x);
                    forceVector = (direction * jumpLength);

                }
                if (dbc.isPressed)
                {
                    Vector3 direction = player2.transform.forward.normalized;
                    forceVector = (-direction * jumpLength);

                }
                if (lbc.isPressed)
                {
                    Vector3 fwd = player2.transform.forward.normalized;
                    Vector3 direction = new Vector3(-fwd.z, -fwd.y, fwd.x);
                    forceVector = (direction * jumpLength);
                }

                // Add movement velocity to jump velocity.
                rb.velocity = forceVector + jumpVector;
            }
            else
            {
                // Check if corresponding DPAD button is pressed and add velocity.

                if (ubc.isPressed)
                {
                    Vector3 direction = player2.transform.forward.normalized;
                    Vector3 forceVector = (direction * jumpLength);
                    rb.velocity = forceVector;

                }
                if (rbc.isPressed)
                {
                    Vector3 fwd = player2.transform.forward.normalized;
                    Vector3 direction = new Vector3(fwd.z, fwd.y, -fwd.x);
                    Vector3 forceVector = (direction * jumpLength);
                    rb.velocity = forceVector;

                }
                if (dbc.isPressed)
                {
                    Vector3 direction = player2.transform.forward.normalized;
                    Vector3 forceVector = (-direction * jumpLength);
                    rb.velocity = forceVector;

                }
                if (lbc.isPressed)
                {
                    Vector3 fwd = player2.transform.forward.normalized;
                    Vector3 direction = new Vector3(-fwd.z, -fwd.y, fwd.x);
                    Vector3 forceVector = (direction * jumpLength);
                    rb.velocity = forceVector;
                }
            }
        }
        player2.transform.rotation = Quaternion.Euler(0, player2.transform.eulerAngles.y, 0);
    }
}
