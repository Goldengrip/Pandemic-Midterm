using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicscript : MonoBehaviour
{
    int amountLeft = 3;
    bool worked = false;

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            worked = true;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Disease" && amountLeft <=3 && worked == true)
        {       
            Debug.Log("It worked");
            Destroy(other.gameObject);
            amountLeft -= 1;
            worked = false;
        }
    }
}
