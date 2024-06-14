using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colorchange : MonoBehaviour
{
    public Material[] materials;  // Array to hold multiple materials
    SkinnedMeshRenderer rend;
    public GameObject obj;

    void Start()
    {
        rend = GetComponent<SkinnedMeshRenderer>();
        rend.material = materials[0];  // Set initial material
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("asgdhasd");
        rend.material = materials[1];
    }
}