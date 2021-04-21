using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
  
    // A function to remove the function from the scene
    public void Destroy()
    {
        Destroy(gameObject);
    }

    // A function to be called once collided
    private void OnTriggerEnter(Collider other)
    {
        // If the Tage of the item it collides with is KillPlane or Bullet
        // Destroy function is called

        if (other.CompareTag("KillPlane"))
            Destroy();

        if (other.CompareTag("Bullet"))
            Destroy();
        
    }
}
