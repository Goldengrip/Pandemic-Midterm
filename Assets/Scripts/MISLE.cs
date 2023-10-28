using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
public class MISLE : MonoBehaviour
{
    public GameObject spawnObject;
    int hasAbility = 3;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m") && hasAbility >=1)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 offset = new Vector3(0, 0, 10);
            Instantiate(spawnObject, pos, Quaternion.identity);
            hasAbility -= 1;
        }
    }
}