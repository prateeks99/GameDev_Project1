using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletPrefab;
    public double firetime = 0;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            animator.SetBool("shoot", true);
            if (Time.time > firetime)
            {
                firetime = Time.time + 0.2;
                shoot();
            }
        }
        else
        {

            animator.SetBool("shoot", false);
        }

    }
    public void shoot()
    {
        animator.SetTrigger("fire");
        GetComponent<AudioSource>().Play();
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

}
