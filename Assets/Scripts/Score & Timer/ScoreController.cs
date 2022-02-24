using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public int score;

    void Start()
    {
        score = 100;
        this.GetComponent<UnityEngine.UI.Text>().text = "Score: " + score.ToString();
    }

    public int getScore()
    {
        return score;
    }

    // Decrement score by given value, do not reduce lower than 0.
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
