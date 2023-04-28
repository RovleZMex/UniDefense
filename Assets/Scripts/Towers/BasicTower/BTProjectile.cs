using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTProjectile : MonoBehaviour
{

    public float speed = 4.5f;
    private float damage;
    private Enemy target;

    public void SetDamage(float damage) { this.damage = damage; } 

    public void MoveTowardsEnemy(GameObject target) {
        this.target = target.GetComponent<Enemy>();
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy") {
            target.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
