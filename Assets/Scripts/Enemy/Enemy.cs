using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UNA CLASE ABSTRACTA NO SE PUEDE INSTANCIAR DIRECTAMENTE, SE DEBE INSTANCIAR
//CON CLASES DERIVADAS DE ESTA.
public abstract class Enemy : MonoBehaviour
{
    public float health;
    public float speed;
    public float damage;

    public abstract void MoveToNextWaypoint();

    public abstract void TakeDamage(float damage);

    //UN METODO ABSTRACTO SE DEBE DEFINIR EN LA CLASE DERIVADA
    public abstract void UseSpecialAbility();
}
