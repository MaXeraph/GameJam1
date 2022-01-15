using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacter : MonoBehaviour
{

    private GameObject _playerChar;
    private Transform _playerTransform;
    private Rigidbody _rigidbody;
    private Vector3 _charSpawnLocation = new Vector3(4.3f, 4.4f, -1.2f);

    private const float _respawnHeight = -10f;


    // public UpdatePlayerInfo UpdatePlayerInfo;
    // Start is called before the first frame update
    void Start()
    {
        _playerChar = GameObject.Instantiate(Resources.Load("Character"), _charSpawnLocation, Quaternion.identity) as GameObject;

        _playerTransform = _playerChar.transform;

        _rigidbody = _playerChar.GetComponent<Rigidbody>();
        // UpdatePlayerInfo = GameObject.FindObjectOfType<UpdatePlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.position.y < _respawnHeight)
        {
            _playerTransform.position = _charSpawnLocation;
            _rigidbody.velocity = Vector3.zero;
        }
    }
}
