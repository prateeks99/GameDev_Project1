
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Boss : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public double firetime = 0;
    [SerializeField] patrol boss;
    public int health = 100;

	public GameObject deathEffect;
    public GameObject damageEffect;
    private double start;

    public LayerMask player;

     void Start()
    {
        start = Time.time;
    }
    void Update()
    {
        if (health<=0)
        {
            
          Die();
        }

        RaycastHit2D ahead;
        bool flip = boss.getdir();
        if (flip)
        {
             ahead = Physics2D.Raycast(firepoint.position, Vector2.right, 7f, player);
        }
        else
        {
            ahead = Physics2D.Raycast(firepoint.position, Vector2.left, 7f, player);
        }
        

        if (ahead.collider != null && Time.time> start + 2)
        {
            shoot();
            start = Time.time;
        }

    }

    void shoot()
    {
        GetComponent<AudioSource>().Play();
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

    public void TakeDamage()
    {
        Instantiate(damageEffect, transform.position, Quaternion.identity);
        health -= 5;
    }
	void Die()
	{
        GameObject Player = GameObject.Find("Player");
        Movement playerscript = Player.GetComponent<Movement>();
        playerscript.bossdead = true;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        print("BossisDead");
		Destroy(gameObject);
        

    }
}