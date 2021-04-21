using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehavior : MonoBehaviour
{
    [Tooltip("A reference to a Bullet Spawn Script")] 
    [SerializeField]
    private BulletSpawnBehavior _bulletScript;

    [Tooltip("A specific speed of how fast a bullet goes")]
    [SerializeField]
    private float _shotSpeed;

    // Update is called once per frame
    void Update()
    {
        // When mouse is clicked it creates the bullet and 
        // sent forward with the speed of the shot speed
        if (Input.GetButtonDown("Fire1") && _bulletScript)
            _bulletScript.Firing(transform.forward * _shotSpeed);
    }
}
