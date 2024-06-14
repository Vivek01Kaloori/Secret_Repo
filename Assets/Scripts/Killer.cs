using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    
    public GameObject cell;

    void Start()
    {
        Destroy(cell,6f);
    }

    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log("AATAGADU1");
        if(other.tag == "Player")
        {
            Debug.Log("AATAGADU2");
            Destroy(cell);
        }
    }
    */

}
