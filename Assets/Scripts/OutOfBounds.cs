using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    PlayerController ps;
    public Vector3 startPos1;
    public Vector3 startPos2;
    public Vector3 startPos3;
    public Vector3 startPos4;

    void Start()
    {
        ps = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Collided with Player
            GameObject go = GameObject.Find("Canvas").transform.Find("Score").gameObject;
            ScoreController s = go.GetComponent<ScoreController>();
            s.decrement(5);

            // need to respawn
            if (ps.lastPlatform == 1)
            {
                player.transform.position = startPos1;
            }
            else if (ps.lastPlatform == 2)
            {
                player.transform.position = startPos2;

            }
            else if (ps.lastPlatform == 3)
            {
                player.transform.position = startPos3;

            }
            else if (ps.lastPlatform == 4)
            {
                player.transform.position = startPos4;

            }
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        else if (collision.gameObject.name == "Obstacle(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
