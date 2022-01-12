using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Items : ScriptableObject
{
    [SerializeField] protected int _id;
    [SerializeField] protected string _name;
    [SerializeField] protected bool stackAble;
    [SerializeField] protected string description;

    protected abstract void Use();
}
