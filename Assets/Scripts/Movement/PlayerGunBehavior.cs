using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private float _speed;

    [SerializeField]
    private Camera _camera;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);

        Vector3 velocity = moveDirection * _speed * Time.deltaTime;

        _rigidbody.MovePosition(transform.position + velocity);

        RaycastHit Hit;

        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out Hit))
        {
            Vector3 look = new Vector3(transform.position.x,  Hit.point.y, transform.position.z) - transform.position;

            Quaternion rotate = Quaternion.LookRotation(look);
            

            _rigidbody.MoveRotation(rotate);
        }


    }
}
