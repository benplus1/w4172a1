using UnityEngine;

public class GunController : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // If Gun collides with palyer, remove Gun and create shoot button.
            this.gameObject.SetActive(false);
            GameObject go = GameObject.Find("Canvas").transform.Find("Shoot").gameObject;
            go.SetActive(true);
        }
    }
}
