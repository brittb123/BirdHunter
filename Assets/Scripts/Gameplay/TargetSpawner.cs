using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    // Lowest Y value to randomize
    public float yMin;

    // Highest Y value to randomize
    public float yMax;

    // Shortest time between spawns
    public float MinTimeInterval;

    // Most time between spawn times
    public float MaxTimeInterval;

    // A variable to tell if the game is over
    public bool GameOver = false;

    // A reference to the target prefab
    public GameObject TargetRef;


    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer of the spawning functions
        StartCoroutine("SpawnTargets");
    }

    // Update is called once per frame
    public IEnumerator SpawnTargets()
    {
        // A variable to keep the randomized value of the y axis
        float RandY = 0;

        // A variable to keep the randomized value of the time interval
        float RandTimeInterval = 0;


        while (!GameOver)
        {
            // Randomly selects a number between the two values
            RandY = Random.Range(yMin, yMax);

            RandTimeInterval = Random.Range(MinTimeInterval, MaxTimeInterval);

            // Sets the vector of the target of its movement before spawned in
            Vector3 Spawn = new Vector3(transform.position.x, RandY, transform.position.z);

            // The object is spawned in set to the vector and set to the basic rotation
            GameObject target = Instantiate(TargetRef.gameObject, Spawn, new Quaternion());

            // The target is applied with the moving component
            EnemyMovementBehavior MovingScript = target.GetComponent<EnemyMovementBehavior>();

            // The Start Cosine is randomized
            MovingScript.StartCos = Random.Range(-1, 1);

            // Waits the time interval before repeating.
            yield return new WaitForSeconds(RandTimeInterval);

        }
    }
}
