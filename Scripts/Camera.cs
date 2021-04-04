using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject stone;
    // Start is called before the first frame update
    void Start()
    {
        stone = GameObject.FindGameObjectsWithTag("stone")[0];
    }

    // Update is called once per frame
    void Update()
    {
        float x = stone.transform.position.x;
        float y = stone.transform.position.y;
        float z = stone.transform.position.z - 1.5f;
        transform.position = new Vector3(x, y, z);
    }
}
