using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneBehavior : MonoBehaviour
{
    // This function is called when a object is collided with another
    private void OnTriggerEnter(Collider other)
    {
        // Gets the target behavior for reference
        TargetBehavior enemy = other.GetComponent<TargetBehavior>();

        // If enemy is not fale or null call its Destroy function.
        if (enemy)
            enemy.Destroy();
    }
}
