using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UNA CLASE ABSTRACTA NO SE PUEDE INSTANCIAR DIRECTAMENTE, SE DEBE INSTANCIAR
//CON CLASES DERIVADAS DE ESTA.
public abstract class Tower : MonoBehaviour
{
    public float damage;
    public float range;
    public float fireRate;

    //UN METODO CON LA PALABRA CLAVE "virtual" PERMITE QUE LAS CLASES DERIVADAS SOBREESCRIBAN
    // EL METODO
    public virtual void Attack(Enemy target) { 
        //TODO: Implementar la logica de ataque de la torre
    }

    //UN METODO CON LA PALABRA CLAVE "virtual" PERMITE QUE LAS CLASES DERIVADAS SOBREESCRIBAN
    // EL METODO
    public virtual void Upgrade() { 
        //TODO: Implementar la logica de mejora de torre
    }

    //UN METODO ABSTRACTO SE DEBE DEFINIR EN LA CLASE DERIVADA
    public abstract void UseSpecialAbility();
}
