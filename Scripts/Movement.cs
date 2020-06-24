
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;


public class Movement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalmove = 0f;
    public float runspeed = 100f;
    public bool bossdead = false;
    private bool jump2 = false;
    public Rigidbody2D rb;
    private bool isclimbing = false;
    public LayerMask ladder;
    [SerializeField] public Animator animator;
    public void jump()
    {
        animator.SetTrigger("Jump");
        jump2 = true;
    }
    private void Update()
    {
         horizontalmove = CrossPlatformInputManager.GetAxis("Horizontal") * runspeed;
        
        if (rb.position.x > -9 && rb.position.y > 2 && bossdead == true)
        {
            SceneManager.LoadScene("Restart Screen");
        }
        if(Input.GetButtonDown("Jump"))
        {
            jump();
        }
        climb();

        animator.SetFloat("velocity", Mathf.Abs(rb.velocity.x));
    }
    public void climb()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, Vector2.up, 0.5f, ladder);
        if (hitinfo.collider != null)
        {
            isclimbing = true;
        }
        else
        {
            isclimbing = false;
        }

        if (isclimbing == true)
        {
            animator.SetBool("climb", true);
            float inputvertical = CrossPlatformInputManager.GetAxis("Vertical");
            rb.velocity = new Vector2(rb.velocity.x, inputvertical * 1f);
            rb.gravityScale = 0;
        }
        else
        {
            animator.SetBool("climb", false);
            rb.gravityScale = 2;
        }

    }
    private void FixedUpdate()
    {
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, jump2);
        jump2 = false;
    }

  

}
