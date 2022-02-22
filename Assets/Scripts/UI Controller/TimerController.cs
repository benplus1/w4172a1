using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    // Start is called before the first frame update
    float timer = 0.0f;

    void Start()
    {
        this.GetComponent<UnityEngine.UI.Text>().text = "Timer: 0s";
    }

    void Update()
    {
        timer += Time.deltaTime;
        int seconds = (int) timer % 60;
        this.GetComponent<UnityEngine.UI.Text>().text = "Timer: " + seconds.ToString() + "s";
    }
    // Update is called once per frame

}
