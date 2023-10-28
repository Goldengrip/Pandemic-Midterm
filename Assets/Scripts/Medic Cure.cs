using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedicCure : MonoBehaviour
{
    public GameObject spawnObject;
    bool hasAbility = true;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("b") && hasAbility)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(spawnObject, pos, Quaternion.identity);
            hasAbility = false;
        }
    }
}
