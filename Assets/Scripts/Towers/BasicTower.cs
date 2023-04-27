using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTower : Tower
{

    public BasicTower(){
        damage = 10f;
        range = 5f;
        fireRate = 1f;
    }

    public override void Attack(Enemy target)
    {
        target.TakeDamage(damage);
    }

    public override void Upgrade()
    {
        damage *= 1.2f;
        range *= 1.1f;
        fireRate *= 0.9f;
    }

    public override void UseSpecialAbility(){
        throw new System.NotImplementedException();
        //TODO: Implementar una habilidad especial para la torre
    }
}
