using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    public Button GunButton;
    private ProjectileGroupController groupControllerScript;

    void Start()
    {
        Button gunButtonComponent = GunButton.GetComponent<Button>();
        gunButtonComponent.onClick.AddListener(Shoot);
        groupControllerScript = GameObject.Find("ProjectileGroup").GetComponent<ProjectileGroupController>();

    }

    void Shoot()
    {
        GameObject projectileGroup = GameObject.Find("ProjectileGroup");
        projectileGroup.GetComponent<ProjectileGroupController>().CreateNewProjectile();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
