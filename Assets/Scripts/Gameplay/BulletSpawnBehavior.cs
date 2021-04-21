using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnBehavior : MonoBehaviour
{
    [Tooltip("An item that is a referernce to the bullet")]
    [SerializeField]
    private GameObject _bullet;

    /// <summary>
    /// The function to be used to spawn and add the behavior and force to the bullet to fire
    /// </summary>
    /// <param name="Force"></param>
    public void Firing(Vector3 Force)
    {
        // The Gameobject is set to be the bullet that is spawned
        GameObject BulletShot = Instantiate(_bullet, transform.position, transform.rotation);

        // Gets and adds the bullet behavior to the shot bullet
        BulletBehavior bulletBehavior = BulletShot.GetComponent<BulletBehavior>();

        // If the bullet behavior is not null add a force to its body equal to the false
        if (bulletBehavior)
            bulletBehavior.Rigidbody.AddForce(Force, ForceMode.Impulse);
    }
}
