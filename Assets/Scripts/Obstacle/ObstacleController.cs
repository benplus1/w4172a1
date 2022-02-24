using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Decrement score by 10 if player hits and obstacle.
            GameObject go = GameObject.Find("Canvas").transform.Find("Score").gameObject;
            ScoreController s = go.GetComponent<ScoreController>();
            s.decrement(10);
        }
    }
}
