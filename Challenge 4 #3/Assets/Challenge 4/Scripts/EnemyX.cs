using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = SpawnManagerX.enemySpeed;
    private Rigidbody enemyRb;
    private GameObject playerGoal;
    private GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.FindGameObjectWithTag("Player Goal");
        enemy = GameObject.FindObjectOfType<EnemyX>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - this.transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

        {
            speed = SpawnManagerX._SpawnManagerX.speedEnemy; --ADD THIS

           Vector3 lookDirection = (playerGoal.transform.position - transform.position).normalized;

            enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

        }


    }

    private void OnCollisionEnter(Collision other)
    {
        // If enemy collides with either goal, destroy it
        if (other.gameObject.name == "Enemy Goal")
        {
            Destroy(gameObject);
        } 
        else if (other.gameObject.name == "Player Goal")
        {
            Destroy(gameObject);
        }

    }

}
