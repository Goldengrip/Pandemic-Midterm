using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    void Start()
    {
        Instantiate(objectToSpawn, transform.position,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
