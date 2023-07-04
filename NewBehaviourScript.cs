using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator anim ;
    public float speed = 5f;
    public Rigidbody2D rb;
    
    Vector2 move;

   
    void FixedUpdate()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        if (move.x != 0)
        {
            anim.SetBool("Player_go", false);
        }
        else

            anim.SetBool("Player_go", true);
            move.y = Input.GetAxisRaw("Vertical");
        
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
