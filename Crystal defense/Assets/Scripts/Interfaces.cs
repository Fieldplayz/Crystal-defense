using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageble
{
    void Damage(float damage);
}

public interface IKill
{
    void Kill();
}
