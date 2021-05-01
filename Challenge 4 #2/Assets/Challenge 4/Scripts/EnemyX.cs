using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : MonoBehaviour
{
    public float speed = SpawnManagerX.enemySpeed;
    private Rigidbody enemyRb;
    public GameObject playerGoal;
    private GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        playerGoal = GameObject.FindGameObjectWithTag("Player Goal");
        Enemy = GameObject.FindObjectOfType<EnemyX>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player goal and move there
        Vector3 lookDirection = (playerGoal.transform.position - this.transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed * Time.deltaTime);

    }

}
