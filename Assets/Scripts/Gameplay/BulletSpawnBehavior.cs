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

        BulletBehavior bulletBehavior = BulletShot.GetComponent<BulletBehavior>();

        if (bulletBehavior)
            bulletBehavior.Rigidbody.AddForce(Force, ForceMode.Impulse);
    }
}
