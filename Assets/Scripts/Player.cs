using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpawn;
    private Rigidbody _playerRb;
    private Vector3 _input = Vector2.zero;
    private int _health = 10;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
        

    }

    void HandleInput()
    {
        //get input
        _input.x = Input.GetAxis("Horizontal") * -1;
        _input.z = Input.GetAxis("Vertical") * -1;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_bullet, _bulletSpawn.position , Quaternion.identity);
        }
    }

    private void Move()
    {
        _playerRb.AddForce((_input.normalized) * _speed, ForceMode.Force);
    }

    private void FixedUpdate()
    {
       Move();
    }
}
