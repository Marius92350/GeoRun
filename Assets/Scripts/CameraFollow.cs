using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    float offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.x - player.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = player.position.x + offset;
        transform.position = pos;
    }
}
