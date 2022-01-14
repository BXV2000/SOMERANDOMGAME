using UnityEngine;

public abstract class DamageableObjects : MonoBehaviour
{
    [SerializeField] protected int _id;
    [SerializeField] protected string _name;
    [SerializeField] protected int hp;
    [SerializeField] public int dmg { get; }

    protected abstract void TakeDmg(int dmg);
    protected abstract void HPEqual0();
}
