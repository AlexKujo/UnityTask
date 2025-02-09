using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }
}
