using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlaneBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        TargetBehavior enemy = other.GetComponent<TargetBehavior>();

        if (enemy)
            enemy.Destroy();
    }
}
