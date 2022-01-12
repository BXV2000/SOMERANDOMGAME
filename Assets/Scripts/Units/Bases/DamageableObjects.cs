using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageableObjects : MonoBehaviour
{
    [SerializeField] protected int _id;
    [SerializeField] protected string _name;
    [SerializeField] protected int hp;
    [SerializeField] protected int dmg;

    protected abstract void TakeDmg(int dmg);
    protected abstract void HPEqual0();
    protected abstract void Attack();

}
