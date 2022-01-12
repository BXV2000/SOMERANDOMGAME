using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : ScriptableObject
{
    protected int _id;
    protected string _name;
    protected bool stackAble;
    protected string description;

    protected abstract void Use();
}
