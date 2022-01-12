using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Creatures
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;

        transform.position += (Vector3)moveAmount;
    }
    override protected void Move()
    {
        return;
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
}
