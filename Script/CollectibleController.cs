using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleController : MonoBehaviour
{
    public GameObject Gold_Coin;
    public GameObject Silver_Coin;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            createCollectible(Silver_Coin);
            createCollectible(Gold_Coin);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void createCollectible(GameObject collectible)
    {
        Vector3 vector = new Vector3(Random.Range(-50.0f, 50.0f), .5f, Random.Range(-50.0f, 50.0f));
        Instantiate(collectible, vector, collectible.transform.rotation, gameObject.transform);
    }

    /*
    public void respawnCollectible()
    {
        GameObject collectible;
        Vector3 vector = new Vector3(Random.Range(-50.0f, 50.0f), .5f, Random.Range(-50.0f, 50.0f));

        if (Random.Range(-1.0f, 1.0f) > 0)
        {
            collectible = Silver_Coin;
        }
        else
        {
            collectible = Gold_Coin;
        }

        Instantiate(collectible, vector, collectible.transform.rotation, gameObject.transform);
    }*/
}
