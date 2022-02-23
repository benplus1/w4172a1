using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalPlatformController : MonoBehaviour
{
    public GameObject canvasGameObject;
    public GameObject joystick;
    public GameObject newJump;

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
            joystick.SetActive(false);
            newJump.SetActive(false);
        }
    }
}
