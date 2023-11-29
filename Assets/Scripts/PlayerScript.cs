using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerScript : MonoBehaviour
{

    UnityEvent PlayAnim;

    private Rigidbody2D rb;
    private Animator anim;

    private float input;

    public int moveSpeed = 5;
    private bool facingRight;

    [Header("Cinematic")]

    public Transform cam;
    public Transform muscleDudes;



    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        facingRight = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //movement

        input = Input.GetAxisRaw("Horizontal");

        float move = input * moveSpeed * Time.deltaTime;
        rb.velocity = new Vector2(move,0);

        if(input == 0)
        {
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isWalking", true);
        }

        if(facingRight && input < 0)
        {
            Flip();
        }
        else if(!facingRight && input > 0)
        {
            Flip();
        }

    }

    private void Flip()
    {
        Vector3 currScale = gameObject.transform.localScale;

        currScale.x *= -1;
        gameObject.transform.localScale = currScale;

        facingRight = !facingRight;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Trigger")
        {
            Debug.Log("Triggered");
            //PlayAnim.Invoke();

            PlayCinematic();
        }
    }

    public void PlayCinematic()
    {
        cam.position = muscleDudes.position;
        Debug.Log("Start");
    }

}
