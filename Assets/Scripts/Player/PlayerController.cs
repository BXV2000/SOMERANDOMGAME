using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Creatures
{   
    public float attackRange = 0f;
    float saveInput;
    bool openStatus = false;

    public IInteractables interactGO;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Interact();
        if(Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.I)){
            OpenInventory();
            openStatus = !openStatus;
        }
    }
    override protected void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
        if(moveInput.x!=0)
            saveInput = moveInput.x;
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
        // Vector2 attackPoint = new Vector2(transform.position.x, transform.position.y);
        // Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint, attackRange);
        // foreach(Collider2D enemy in hitEnemies){
        //     Debug.Log("Hit");
        // }

        if (saveInput>0){
            Debug.Log("Right");
        }
        if (saveInput<0){
            Debug.Log("Left");
        }

    }

    public void Interact()
    {
        if(Input.GetKeyDown(KeyCode.T))
        interactGO.Interact();
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

    void OpenInventory(){
        if(openStatus==false)
            Debug.Log("Inventory Opened");
        if(openStatus==true)
            Debug.Log("Inventory Closed");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        interactGO = collision.GetComponent<IInteractables>();
        Debug.Log("Player collide sth");
    }
    void OnTriggerExit2D(Collider2D collsion)
    {
        interactGO = null;
    }

}
