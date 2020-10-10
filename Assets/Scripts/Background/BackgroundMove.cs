using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour {
    private Vector3 _firstPosition;
    public float _speed, _speedShake, _amountShake = 1f;
    public bool _parent = false;
    void Start () {
        _firstPosition = transform.position;
    }

    // Update is called once per frame
    void Update () {
        if (!_parent) {
            transform.position = new Vector3 (transform.position.x - _speed * Time.deltaTime, transform.position.y + _speed * Time.deltaTime, 0f);
            if (transform.position.x <= _firstPosition.x - 14f) {
                transform.position = new Vector3 (_firstPosition.x + 14f, _firstPosition.y - 14f, 0);
            }
        } else {
            transform.rotation = Quaternion.Euler (0f, 0f, _amountShake * Mathf.Sin (Time.time * _speedShake));
        }
    }
}