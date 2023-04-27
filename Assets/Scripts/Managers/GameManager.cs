using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject basicEnemy;

    [SerializeField]
    private int currentHorde = 1;

    [SerializeField]
    private int enemies = 0;

    [SerializeField]
    private int credits = 0;

    [SerializeField]
    public Transform[] waypoints;

    // Update is called once per frame
    void Update()
    {
        if(enemies != 5) CreateEnemy();
    }

    private void CreateEnemy(){
        Instantiate(basicEnemy, Vector3.zero, Quaternion.identity);
        enemies += 1;
    }

    public void RemoveEnemy(GameObject target){
        Destroy(target);
        enemies -= 1;
        credits += 20;
    }
}
