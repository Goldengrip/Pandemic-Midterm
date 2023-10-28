using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medicbomb : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Disease")
        {
            Debug.Log("It worked");
            Destroy(other.gameObject);
            Invoke("Death", 2f);
        }
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
