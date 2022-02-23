using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;

    void Start()
    {
        score = 100;
        this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getScore()
    {
        return score;
    }

    public void decrement(int value)
    {
        score -= value;
        if (score < 0)
        {
            score = 0;
        }
        this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }
}
