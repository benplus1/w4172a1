using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Destroy projectile after 5 seconds.
        Destroy(this.gameObject, 5);
    }
}
