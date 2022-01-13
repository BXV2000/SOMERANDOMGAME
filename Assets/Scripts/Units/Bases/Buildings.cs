using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buildings : DamageableObjects, IInteractables
{
    protected abstract void Broken();
    public void Interact()
    {
        return;
    }
}
