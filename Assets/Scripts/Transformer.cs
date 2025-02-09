using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private float _changeScale;

    // Update is called once per frame
    void Update()
    {
        _changeScale = _scaleSpeed * Time.deltaTime;

        transform.Translate(transform.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += new Vector3(_changeScale, _changeScale, _changeScale);
    }
}
