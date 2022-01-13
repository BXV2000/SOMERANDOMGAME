using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Slime : Enemies
{
    private Vector2 randomPoint;

    private void Start() 
    {
        InvokeRepeating("ChoseRandomDir", 0f, 3f);
        targetChecker.GetComponent<TargetChecker>().SetMyParent(this.gameObject);
    }
    private void Update() 
    {
        if(!target)
            Move();
    }

    #region Override
    override protected void Move()
    {
        Debug.Log("Move");
        transform.position += (transform.position - (Vector3)randomPoint).normalized * speed * Time.deltaTime;
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
    public override void DetectTarget(GameObject _target)
    {
        target = _target;
        Chase();
    }

    #endregion
    protected void Chase()
    {
        if(target)
            this.GetComponent<AIDestinationSetter>().target = target.transform;
        else
        {
            this.GetComponent<AIDestinationSetter>().target = null;
        }
    }

    private void ChoseRandomDir()
    {
        float randx = Random.Range(transform.position.x - 1f,transform.position.x + 1f);
        float randy = Random.Range(transform.position.y - 1f,transform.position.y + 1f);
        randomPoint = new Vector2(randx, randy);
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // TakeDmg(other.gameObject.GetComponent<DamageableObjects>().dmg);
    }
    private void SetTarget()
    {
        return;
    }
}
