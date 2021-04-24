using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed = 10;
    private float leftBound = -11;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // If game is not over, move to the left
        if (PlayerControllerX.gameOver==false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // If object goes off screen that is NOT the background, destroy it
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
