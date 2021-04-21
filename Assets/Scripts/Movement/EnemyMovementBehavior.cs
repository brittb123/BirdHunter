using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MonoBehaviour
{
    public float MinHorizontalSpeed;

    public float StartCos;

    public float MaxHorizontalSpeed;
    // Update is called once per frame
    void Update()
    {

        float RandHorizontalSpeed;

        RandHorizontalSpeed = Random.Range(MinHorizontalSpeed, MaxHorizontalSpeed);

        transform.position += new Vector3(0, 0, -RandHorizontalSpeed);
        StartCos += Time.deltaTime;
        transform.position += new Vector3(0, Mathf.Cos(StartCos), 0) * RandHorizontalSpeed * Time.deltaTime;
    }
}
