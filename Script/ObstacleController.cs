using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject Obstacle;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 3; i++)
        {
            createObstacleRandomly();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createObstacleRandomly()
    {
        Vector3 vector = new Vector3(Random.Range(-50.0f, 50.0f), 2.0f, Random.Range(-50.0f, 50.0f));

        Instantiate(Obstacle, vector, Obstacle.transform.rotation, gameObject.transform);
    }

    public void createObstacle(GameObject car)
    {
        Vector3 vector = car.transform.position - car.transform.right * 1.45f;
        Instantiate(Obstacle, new Vector3(vector.x, 2.0f, vector.z), Obstacle.transform.rotation, gameObject.transform);
    }
}
