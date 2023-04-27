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

    //UN METODO CON LA PALABRA CLAVE "virtual" PERMITE QUE LAS CLASES DERIVADAS SOBREESCRIBAN
    // EL METODO
    public virtual void MoveToNextWaypoint() { 
        //TODO: Implementar el movimiento del enemigo hacia el siguiente waypoint
    }

    public virtual void TakeDamage(float damage) {
        health -= damage;
        if (health <= 0.0f) { 
            //TODO: Implementar eliminacion del enemigo
        }
    }

    //UN METODO ABSTRACTO SE DEBE DEFINIR EN LA CLASE DERIVADA
    public abstract void UseSpecialAbility();
}
