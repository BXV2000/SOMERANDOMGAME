using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Creatures
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    override protected void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;

        transform.position += (Vector3)moveAmount;
        MoveAnimationUpdate(moveInput);
    }
    override protected void Die()
    {
        return;
    }
    override protected void TakeDmg(int dmg)
    {
        return;
    }
    override protected void HPEqual0() 
    {
        return;
    }
    override protected void Attack()
    {
        return;
    }

    void MoveAnimationUpdate(Vector2 moveInput)
    {
        if(moveInput == Vector2.zero)
        {
            anim.SetBool("IsRunning", false);
        }
        else
        {
            anim.SetBool("IsRunning", true);
        }
    }
}
