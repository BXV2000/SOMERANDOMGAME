﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Creatures : DamageableObjects
{
    protected float speed;

    protected abstract void Move();
    protected abstract void Die();
}
