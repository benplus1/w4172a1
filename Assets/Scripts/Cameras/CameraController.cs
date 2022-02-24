using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 cameraOffset;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // This changes only the Main Camera position relative to the player position. The offset is preset.
        this.transform.position = player.transform.position + cameraOffset;
    }

}
