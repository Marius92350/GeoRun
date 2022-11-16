using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platformPrefab;

    public GameObject player;
    float distanceMinimum;

    // Start is called before the first frame update
    void Start()
    {
        CreatePlatform();
        distanceMinimum = transform.position.x;
    }

    public void CreatePlatform()
    {
        Instantiate(platformPrefab, transform.position, Quaternion.identity);
    }

    public void Update()
    {
        float distanceActuelle = transform.position.x - player.transform.position.x;

        if(distanceActuelle < distanceMinimum)
        {
            Vector3 pos = transform.position;
            pos.x += distanceMinimum;
            transform.position = pos;
            CreatePlatform();
        }
    }
}
