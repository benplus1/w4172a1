using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPosition;
    public Vector3 startPosition2;
    public GameObject player2;
    public Button restartButton;
    public GameObject canvas;
    public GameObject scs;
    public GameObject tcs;
    public GameObject player;
    public GameObject gun;
    public GameObject obs;
    public GameObject plat;
    public GameObject outOfBounds;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        restartButton.onClick.AddListener(RestartGame);
    }

    private void OnDisable()
    {
        restartButton.onClick.RemoveListener(RestartGame);
    }

    void RestartGame()
    {
        player2.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player2.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        player2.GetComponent<PlayerController>().lastPlatform = 3;

        player.SetActive(true);
        player2.tag = "Untagged";
        player.tag = "Player";
        player2.SetActive(false);

        plat.GetComponent<ChangeUI>().hitOnce = false;

        player2.transform.position = startPosition2;

        player.transform.position = startPosition;

        Camera.main.GetComponent<CameraController>().player = player;

        scs.GetComponent<ScoreController>().score = 100;
        scs.GetComponent<UnityEngine.UI.Text>().text = "Score: " + scs.GetComponent<ScoreController>().score.ToString();

        tcs.GetComponent<TimerController>().timer = 0;
        int seconds = (int) tcs.GetComponent<TimerController>().timer % 60;
        tcs.GetComponent<UnityEngine.UI.Text>().text = "Timer: " + seconds.ToString() + "s";

        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Obs");
        foreach (GameObject prefab in prefabs)
        {
            Destroy(prefab);
        }

        // set relevant objects to false and true
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        player.GetComponent<PlayerController>().lastPlatform = 1;

        obs.GetComponent<ObstaclesGroupController>().createObstacles();
        Time.timeScale = 1;
        outOfBounds.GetComponent<OutOfBounds>().player = player;
        gun.SetActive(true);
        restartButton.gameObject.SetActive(false);
    }
}
