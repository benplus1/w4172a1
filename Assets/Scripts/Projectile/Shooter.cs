using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public Button GunButton;
    private ProjectileGroupController groupControllerScript;

    void Start()
    {
        // Add shoot listener to GunButton.
        Button gunButtonComponent = GunButton.GetComponent<Button>();
        gunButtonComponent.onClick.AddListener(Shoot);
        groupControllerScript = GameObject.Find("ProjectileGroup").GetComponent<ProjectileGroupController>();
    }

    void Shoot()
    {
        GameObject projectileGroup = GameObject.Find("ProjectileGroup");
        projectileGroup.GetComponent<ProjectileGroupController>().CreateNewProjectile();
    }
}
