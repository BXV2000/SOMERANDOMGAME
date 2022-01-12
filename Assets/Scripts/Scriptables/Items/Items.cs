using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items/Nothing")]
public abstract class Items : ScriptableObject
{
    [SerializeField] protected int _id; public int id { get {return _id;} }
    [SerializeField] protected string _name; public string name_ { get {return _name;} }
    [SerializeField] protected Sprite _icon; public Sprite icon { get{return _icon;} }
    [SerializeField] protected bool _stackAble; public bool stackAble  { get {return _stackAble;} }
    [SerializeField] protected string _description; public string description { get {return _description;} }

    public abstract void Use();
}
