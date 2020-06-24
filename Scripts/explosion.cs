using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour
{
    private double deletetime;

    // Start is called before the first frame update
    void Start()
    {
        deletetime = Time.time + 0.5;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > deletetime)
        {
            Destroy(gameObject) ;
        }
    }
}
