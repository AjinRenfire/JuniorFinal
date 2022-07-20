using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    private int _round = 1;
    private GameObject[] _enemiesInScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Spawn()
    {
        _enemiesInScene = GameObject.FindGameObjectsWithTag("Enemy");
        if(_enemiesInScene == null && _round == 1)
        {   
            _round += 1;
            return;
        }
        
        if (_enemiesInScene == null && _round >1)
        {
            _round += 1;
           
        }
        if(_round > 1 && _round <= 4 )
        {

        }

    }
    // Update is called once per frame
    void Update()
    {
        Spawn();
    }
}
