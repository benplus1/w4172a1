using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour
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
            Destroy(this.gameObject);
            GameObject go = GameObject.Find("Canvas").transform.Find("Shoot").gameObject;
            go.SetActive(true);
        }
    }
}
