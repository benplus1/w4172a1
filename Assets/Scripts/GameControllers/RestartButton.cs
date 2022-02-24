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
        // Set current character to 0 and reset lastPlatform.
        player2.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player2.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        player2.GetComponent<PlayerController>().lastPlatform = 3;

        // Switch characters.
        player.SetActive(true);
        player2.tag = "Untagged";
        player.tag = "Player";
        player2.SetActive(false);

        // Modify the ChangeUI behavior on the third platform.
        plat.GetComponent<ChangeUI>().hitOnce = false;

        // Reset character models to start positions.
        player2.transform.position = startPosition2;
        player.transform.position = startPosition;

        // Reset main camera to point at player.
        Camera.main.GetComponent<CameraController>().player = player;

        // Set score and timer to original values.
        scs.GetComponent<ScoreController>().score = 100;
        scs.GetComponent<UnityEngine.UI.Text>().text = "Score: " + scs.GetComponent<ScoreController>().score.ToString();
        tcs.GetComponent<TimerController>().timer = 0;
        int seconds = (int) tcs.GetComponent<TimerController>().timer % 60;
        tcs.GetComponent<UnityEngine.UI.Text>().text = "Timer: " + seconds.ToString() + "s";

        // Destroy current obstacles that still exist.
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag("Obs");
        foreach (GameObject prefab in prefabs)
        {
            Destroy(prefab);
        }

        // Set the player velocity to 0 as well as its lastPlatform touched.
        player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        player.GetComponent<PlayerController>().lastPlatform = 1;

        // Create new obstacles and reset Gun object.
        obs.GetComponent<ObstaclesGroupController>().createObstacles();
        gun.SetActive(true);

        // Let out of bounds detect right character model.
        outOfBounds.GetComponent<OutOfBounds>().player = player;

        // Disable restart button.
        restartButton.gameObject.SetActive(false);

        // Restart game.
        Time.timeScale = 1;
    }
}
