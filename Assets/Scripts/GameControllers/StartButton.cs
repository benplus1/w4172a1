using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton;

    void Awake()
    {
        // Set time scale to 0 at very start.
        Time.timeScale = 0f;
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
    }

    private void StartGame()
    {
        // Start game.
        Time.timeScale = 1f;

        // Hide button.
        startButton.gameObject.SetActive(false);
    }
}
