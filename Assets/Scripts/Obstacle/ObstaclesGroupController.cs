using UnityEngine;

public class ObstaclesGroupController : MonoBehaviour
{
    public GameObject obstaclePrefab;

    void Start()
    {
        createObstacles();
    }

    // Create grid of 9 obstacles.
    public void createObstacles()
    {
        Vector3 location1 = new Vector3(-1.0f, 1.0f, -0.9f);
        Vector3 location2 = new Vector3(0.0f, 1.0f, -0.9f);
        Vector3 location3 = new Vector3(1.0f, 1.0f, -0.9f);
        Vector3 location4 = new Vector3(-1.0f, 2.0f, -0.9f);
        Vector3 location5 = new Vector3(0.0f, 2.0f, -0.9f);
        Vector3 location6 = new Vector3(1.0f, 2.0f, -0.9f);
        Vector3 location7 = new Vector3(-1.0f, 3.0f, -0.9f);
        Vector3 location8 = new Vector3(0.0f, 3.0f, -0.9f);
        Vector3 location9 = new Vector3(1.0f, 3.0f, -0.9f);

        CreateNewObstacle(location1);
        CreateNewObstacle(location2);
        CreateNewObstacle(location3);
        CreateNewObstacle(location4);
        CreateNewObstacle(location5);
        CreateNewObstacle(location6);
        CreateNewObstacle(location7);
        CreateNewObstacle(location8);
        CreateNewObstacle(location9);
    }

    // Create object from desired location and prefab.
    public void CreateNewObstacle(Vector3 location)
    {
        GameObject new_obj = GameObject.Instantiate(obstaclePrefab);
        new_obj.transform.SetParent(GameObject.Find("ObstaclesGroup").transform);
        new_obj.transform.position = location;
        new_obj.transform.eulerAngles = new Vector3(0, 0, 0);
    }

}
