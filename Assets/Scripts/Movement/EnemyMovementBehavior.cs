using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
{
    // The lowest speed that is used in random number generation
    public float MinHorizontalSpeed;

    // The starrting Cosine 
    public float StartCos;

    // The max speed of the target to move at
    public float MaxHorizontalSpeed;

    // Update is called once per frame
    void Update()
    {
        // The randomized floating speed variable
        float RandHorizontalSpeed;

        // Randomizes a number between the values given in
        RandHorizontalSpeed = Random.Range(MinHorizontalSpeed, MaxHorizontalSpeed);

        // Sets a vector to move with the Horizontal speed on the z axis
        transform.position += new Vector3(0, 0, -RandHorizontalSpeed);

        // Changes the Cosine as the frames move on
        StartCos += Time.deltaTime;

        // Sets a new vector to move up and down on the y using Cosine 
        // and the speed as well as the time
        transform.position += new Vector3(0, Mathf.Cos(StartCos), 0) * RandHorizontalSpeed * Time.deltaTime;
    }
}
