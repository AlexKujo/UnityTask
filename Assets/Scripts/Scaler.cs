using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float scaleChange;

    // Update is called once per frame
    void Update()
    {
        scaleChange = _speed * Time.deltaTime;

        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}
