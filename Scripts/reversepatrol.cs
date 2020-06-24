using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reversepatrol : MonoBehaviour
{
    public float speed;
    public LayerMask platform;

    public Transform GroundDetection;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(GroundDetection.position, Vector2.up, 1f, platform);
        print(groundInfo);
        if (groundInfo.collider == null)
        {
            transform.Rotate(0f, 180f, 0f);
        }
    }
}
