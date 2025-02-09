using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * _speed * Time.deltaTime);
    }
}
