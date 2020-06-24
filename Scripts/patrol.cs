using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed;
    public LayerMask platform;
    private bool isright = true;
    public Transform GroundDetection;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.down, 1f, platform);
        if (groundInfo.collider == null)
        {
            isright = !isright;
            transform.Rotate(0f, 180f, 0f);
        }
    }
    public bool getdir()
    {
        return isright;
    }
}
