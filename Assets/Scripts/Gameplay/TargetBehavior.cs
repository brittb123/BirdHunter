using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public void Destroy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("KillPlane"))
            Destroy();

        if (other.CompareTag("Bullet"))
            Destroy();
    }
}
