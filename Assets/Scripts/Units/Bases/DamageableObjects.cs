using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageableObjects : MonoBehaviour
{
    protected int _id;
    protected string _name;
    protected int hp;
    protected int dmg;

    protected abstract void TakeDmg(int dmg);
    protected abstract void HPEqual0();
    protected abstract void Attack();

}
