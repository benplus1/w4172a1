using UnityEngine;

public class ChangeUI : MonoBehaviour
{
    public GameObject player2;
    public GameObject player;
    public bool hitOnce = false;
    public GameObject upButton;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject downButton;
    public GameObject jumpButton;

    public GameObject outOfBounds;

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Player" && !hitOnce)
        {
            // Switch the players when the third platform is touched.
            player2.SetActive(true);
            player.tag = "Untagged";
            player2.tag = "Player";
            player.SetActive(false);

            // Enable the DPAD buttons.
            upButton.SetActive(true);
            downButton.SetActive(true);
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            jumpButton.SetActive(true);

            // Set the camera, ensure this function isn't called again, and what the OutOfBounds volume should look for.
            Camera.main.GetComponent<CameraController>().player = player2;
            hitOnce = true;
            outOfBounds.GetComponent<OutOfBounds>().player = player2;
        }
    }
}
