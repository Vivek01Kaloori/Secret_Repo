using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_coloeChange : MonoBehaviour
{
    public Color startColor = Color.blue;
    public Color endColor = Color.black;
    [Range(0,10)]
    public float speed = 1;
    Renderer ren;
    // Start is called before the first frame update
    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ren.material.color = Color.Lerp(startColor,endColor,Mathf.PingPong(Time.time * speed, 1));
    }
}
