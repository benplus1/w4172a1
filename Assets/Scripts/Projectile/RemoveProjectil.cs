using UnityEngine;

public class RemoveProjectil : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // Remove the shoot button when second platform is hit.
            GameObject go = GameObject.Find("Canvas").transform.Find("Shoot").gameObject;
            go.SetActive(false);
        }
    }
}
