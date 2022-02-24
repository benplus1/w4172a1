using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player2;
    public GameObject player;
    public bool hitOnce = false;
    public GameObject upButton;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject downButton;
    public GameObject jumpButton;

    public GameObject outOfBounds;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Player" && !hitOnce)
        {
            // change character model
            player2.SetActive(true);
            player.tag = "Untagged";
            player2.tag = "Player";
            player.SetActive(false);
            // change UI
            Camera.main.GetComponent<CameraController>().player = player2;
            hitOnce = true;

            upButton.SetActive(true);
            downButton.SetActive(true);
            leftButton.SetActive(true);
            rightButton.SetActive(true);
            jumpButton.SetActive(true);

            outOfBounds.GetComponent<OutOfBounds>().player = player2;
        }
    }
}
