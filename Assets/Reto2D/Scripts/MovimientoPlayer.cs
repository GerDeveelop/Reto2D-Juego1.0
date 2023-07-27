using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;

    private float DireX = 0f;
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float JumpForce = 7f;
    public AudioSource JumpSound;

    private enum MovementState { idle, running, jumping, falling }
    
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<BoxCollider2D>();

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        DireX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(DireX * moveSpeed, rb.velocity.y);
       

        if (Input.GetButtonDown("Jump") && IsGrounded()){

            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            JumpSound.Play();
        }
 
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        MovementState state;

        if (DireX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if (DireX < 0f)
        {
           state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.velocity.y > 0.1f)
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -0.1f)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
    }

    private  bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("damage"))
        {

            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            JumpSound.Play();

        }

    }

}
