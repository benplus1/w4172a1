using UnityEngine;
using UnityEngine.UI;

public class GoalPlatformController : MonoBehaviour
{
    public GameObject upButton;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject downButton;
    public GameObject jumpButton;

    public Button restartButton;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            // Stop objects from moving.
            Time.timeScale = 0;

            // Enable restart button.
            restartButton.gameObject.SetActive(true);

            // Ensure buttons are not in the middle of processing presses.
            JumpButton jbc = jumpButton.GetComponent<JumpButton>();
            jbc.isPressed = false;
            UpButton ubc = upButton.GetComponent<UpButton>();
            ubc.isPressed = false;
            LeftButton lbc = leftButton.GetComponent<LeftButton>();
            lbc.isPressed = false;
            RightButton rbc = rightButton.GetComponent<RightButton>();
            rbc.isPressed = false;
            DownButton dbc = downButton.GetComponent<DownButton>();
            dbc.isPressed = false;

            // Set directional pad and jump UI to non-active.
            upButton.SetActive(false);
            downButton.SetActive(false);
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            jumpButton.SetActive(false);
        }
    }
}
