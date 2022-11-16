using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateformAutokill : MonoBehaviour
{
    GameObject player;

    const float distanceAutoKill = 30;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float distanceActuelle = player.transform.position.x - transform.position.x;

        if(distanceActuelle > distanceAutoKill)
        {
            Destroy(gameObject);
        }
    }
}
