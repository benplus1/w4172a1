using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPlatformController : MonoBehaviour
{
    public GameObject canvasGameObject;
    public GameObject upButton;
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject downButton;
    public GameObject jumpButton;

    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            Time.timeScale = 0;
            restartButton.gameObject.SetActive(true);
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
            upButton.SetActive(false);
            downButton.SetActive(false);
            leftButton.SetActive(false);
            rightButton.SetActive(false);
            jumpButton.SetActive(false);



        }
    }
}
