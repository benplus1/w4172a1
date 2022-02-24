using UnityEngine;

public class ProjectileGroupController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject player;
    float power = 1500f;
    public float offset;

    public void CreateNewProjectile()
    {
        // Spawn new projectile and set it under parent.
        GameObject new_obj = GameObject.Instantiate(projectilePrefab, player.transform.position - (Vector3.forward/offset), player.transform.rotation);
        new_obj.transform.SetParent(GameObject.Find("ProjectileGroup").transform);

        // Launch projectile.
        Vector3 fwd = transform.TransformDirection(player.transform.rotation * Vector3.forward);
        new_obj.GetComponent<Rigidbody>().AddForce(fwd * power);
    }
}
