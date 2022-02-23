using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileGroupController : MonoBehaviour
{
    public int numberOfProjectiles;
    public GameObject projectilePrefab;
    public float height_min;
    public float height_max;
    public GameObject player;
    float power = 1500f;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateNewProjectile()
    {
        GameObject new_obj = GameObject.Instantiate(projectilePrefab, player.transform.position - (Vector3.forward/offset), player.transform.rotation);
        new_obj.transform.SetParent(GameObject.Find("ProjectileGroup").transform);

        Vector3 fwd = transform.TransformDirection(player.transform.rotation * Vector3.forward);
        new_obj.GetComponent<Rigidbody>().AddForce(fwd * power);
    }
}
