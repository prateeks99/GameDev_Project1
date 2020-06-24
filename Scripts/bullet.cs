using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject impactEffect;
    public float speed = 5f;
    public Rigidbody2D rb;
	private double start;
    void Start()
    {
        
        rb.velocity = transform.right * speed;
		start = Time.time + 1;
    }

    void Update()
    {
        if(Time.time>start)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
	{
		Enemy enemy = hitInfo.GetComponent<Enemy>();
        Boss boss = hitInfo.GetComponent<Boss>();
        if (boss != null)
        {
            boss.TakeDamage();
            Destroy(gameObject);
        }
        if (enemy != null)
		{
			enemy.Die();
            Destroy(gameObject);
        }

	}



}
