using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airpatrol : MonoBehaviour
{
    public float speed;
    private float starttime;
    public float rotatetime;
    public Transform GroundDetection;
     void Start()
    {
        starttime = Time.time;
        transform.Translate(Vector3.up * Time.deltaTime);
    }
    void Update()
    {
        
        if(Time.time < starttime + 1)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
        }
        else if(Time.time > starttime + 1)
        {
            transform.Translate(Vector3.up  * Time.deltaTime);
            if(Time.time > starttime+2)
            {
                starttime = Time.time;
            }
        }
       
    }
}
