using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health;
    public int numofhearts;
    public Rigidbody2D rb;

    public Image[] hearts;
    public Sprite full;

    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            
            if(i< health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if(health<0)
        {
            die();
        }
        if(rb.position.y <= -4 )
        {
            Invoke("die", 0.5f);
        }
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();

        if (enemy != null)
        {
            health -= 1;
        }
    }
    public void takedamage()
    {
        health -= 1;
    }
    public void die()
    {
        //go to restart screen
        print("Player is Dead");
        SceneManager.LoadScene("Restart Screen");
    }
}
