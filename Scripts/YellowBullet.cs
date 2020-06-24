using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour
{
    public GameObject impactEffect;
    public float speed = 2f;
    public Rigidbody2D rb;
    private double start;
    void Start()
    {
        rb.velocity = transform.right * speed;
        start = Time.time + 1;
    }

    void Update()
    {
        if (Time.time > start)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health player = hitInfo.GetComponent<Health>();

        if (player != null)
        {
            player.takedamage();
            Destroy(gameObject);
        }
    }



}
