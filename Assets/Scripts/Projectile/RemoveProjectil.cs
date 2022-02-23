using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveProjectil : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject go = GameObject.Find("Canvas").transform.Find("Shoot").gameObject;
            go.SetActive(false);
        }
    }
}
