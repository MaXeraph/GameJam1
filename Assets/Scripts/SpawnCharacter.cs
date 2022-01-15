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

    public int PlayerLivesLeft;
    public const int NumOfLives = 3;

    public bool GameEnded = false;

    public UpdatePlayerInfo UpdatePlayerInfo;


    // public UpdatePlayerInfo UpdatePlayerInfo;
    // Start is called before the first frame update
    void Start()
    {
        _playerChar = GameObject.Instantiate(Resources.Load("Character"), _charSpawnLocation, Quaternion.identity) as GameObject;

        _playerTransform = _playerChar.transform;

        _rigidbody = _playerChar.GetComponent<Rigidbody>();
        PlayerLivesLeft = NumOfLives;
        UpdatePlayerInfo = GameObject.FindObjectOfType<UpdatePlayerInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerTransform.position.y < _respawnHeight)
        {
            if (PlayerLivesLeft > 0)
            {
                _playerTransform.position = _charSpawnLocation;
                _rigidbody.velocity = Vector3.zero;
                PlayerLivesLeft -= 1;
                UpdatePlayerInfo.UpdatePlayerLivesText(PlayerLivesLeft);
            }
            else
            {
                EndGame();
                UpdatePlayerInfo.DisplayGameOver();
            }
        }
    }
    void EndGame()
    {
        GameEnded = true;
        Time.timeScale = 0;
        Debug.Log("Game has ended");
    }
}
