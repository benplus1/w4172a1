using UnityEngine;

public class TimerController : MonoBehaviour
{
    public float timer = 0.0f;

    void Start()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "Timer: 0s";
    }

    // Update the timer according to the number of seconds passed.
    void Update()
    {
        timer += Time.deltaTime;
        int seconds = (int) timer % 60;
        this.GetComponent<UnityEngine.UI.Text>().text = "Timer: " + seconds.ToString() + "s";
    }
}
