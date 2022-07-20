using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerPostion;
    [SerializeField] private Material[] _materials;
    private Rigidbody _enemyRb;
    private float _health = 5;
    
  
    // Start is called before the first frame update
    void Start()
    {
        _enemyRb = gameObject.GetComponent<Rigidbody>();

    }

    private Vector3 GetDirection()
    {
        return _playerPostion.position.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        HandleColor();
       if(_health <= 0)
       {
            Destroy(gameObject);
       }

    }

    private void HandleColor()
    {
        if(_health <= 3 && _health> 1)
        {
            gameObject.GetComponent<Renderer>().material = _materials[1];
        }
        if( _health == 1)
        {
            gameObject.GetComponent<Renderer>().material = _materials[0];
        }
    }

    private void FixedUpdate()
    {
        _enemyRb.AddForce(GetDirection() * _speed, ForceMode.Acceleration);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        _health -= 1f;
    }
}
