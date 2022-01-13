using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : Mobs
{
    [SerializeField] protected GameObject targetChecker;
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
    public virtual void DetectTarget(GameObject target)
    {
        return;
    }
}
