using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Anotherplayermovmentcuthefirstoneisnottheway : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float ObjectSpeed;

    int NextPosIndex;
    Transform NextPos;
    
    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }
     void MoveGameObject()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            NextPosIndex++;
            if(NextPosIndex >= Positions.Length)
            {
                NextPosIndex = 0;
            }
            NextPos = Positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
        }
    }
}
