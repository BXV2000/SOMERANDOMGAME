using UnityEngine;

public class PlayerController : Creatures
{   
    private IInteractables interactGO; public IInteractables _interactGO { set {interactGO = value;} }
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        Move();
        Interact();
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
    public void Interact()
    {
        if(Input.GetKeyDown(KeyCode.T) && interactGO != null)
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

}
