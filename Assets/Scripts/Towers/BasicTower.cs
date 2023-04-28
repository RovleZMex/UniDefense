using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTower : Tower
{
    TowerManager tm;

    private GameObject[] enemies;
    private GameObject target;
    private Enemy targetScript;

    bool isTargeting = false;
    bool isShooting = false;

    public BasicTower(){
        damage = 20f;
        range = 500f;
        fireRate = 0.5f;
    }

    private void Start()
    {
        tm = GameObject.Find("TowerManager").GetComponent<TowerManager>();
    }

    private void Update()
    {
        if (!isTargeting)
        {
            enemies = tm.enemies; // Actualizar la lista de enemigos
            getTarget(); // Actualizar el objetivo
        }
        else {
            if (!isShooting) {
                isShooting = true;
                InvokeRepeating("Attack", 0f, fireRate);
            }
        };
    }

    private void getTarget() {
        float bestDistance = Mathf.Infinity;
        GameObject bestCandidate = null;
        foreach(GameObject enemy in enemies) {
            float distance = Vector2.Distance(gameObject.transform.position, enemy.transform.position);
            if (distance < bestDistance) {
                bestDistance = distance;
                bestCandidate = enemy;
            }
        }
        if (bestCandidate != null) {
            isTargeting = true;
            target = bestCandidate;
            targetScript = target.GetComponent<Enemy>();
        }

    }

    public override void Attack()
    {
        //TODO: Implementar algun tipo de proyectil para visualizar el disparo de la torre
        if (Vector2.Distance(gameObject.transform.position, target.transform.position) <= range)
        {
            targetScript.TakeDamage(damage);
            if (targetScript.health - damage <= 0.0f)
            {
                CancelInvoke("Attack");
                isTargeting = false;
                target = null;
                targetScript = null;
                isShooting = false;
            }
        }
        else {
            CancelInvoke("Attack");
            isTargeting = false;
            target = null;
            targetScript = null;
            isShooting = false;
            return;
        }
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
