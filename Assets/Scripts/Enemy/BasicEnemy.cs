using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Enemy
{

    [SerializeField]
    private Transform[] waypoints;

    private int waypointIndex = 0;

    GameManager gm;

    BasicEnemy(){
        health = 70.0f;
        speed = 300.0f;
        damage = 7.0f;
    }

    private void Start() {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        waypoints = gm.waypoints;
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update() {
        if(waypointIndex != waypoints.Length)   MoveToNextWaypoint();
        else gm.RemoveEnemy(gameObject);
    }

    public override void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0.0f) gm.RemoveEnemy(gameObject);
    }

    public override void MoveToNextWaypoint()
    {
        if (waypointIndex <= waypoints.Length - 1){
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position, speed * Time.deltaTime);
        }
        
        if(Vector2.Distance(transform.position, waypoints[waypointIndex].transform.position) == 0){
            waypointIndex += 1;
        }
    }

    public override void UseSpecialAbility()
    {
        throw new System.NotImplementedException();
    }
}
