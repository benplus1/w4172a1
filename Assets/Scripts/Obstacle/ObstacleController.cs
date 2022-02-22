using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

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
        if (collision.gameObject.name == "Player")
        {
            // Collided with Player
            GameObject go = GameObject.Find("Canvas").transform.Find("Score").gameObject;
            ScoreController s = go.GetComponent<ScoreController>();
            s.decrement(10);
        }
    }
}
