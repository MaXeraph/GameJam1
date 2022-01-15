using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePlayerInfo : MonoBehaviour
{
    private GameObject _playerLivesObj;
    public GameObject GameOverText;

    private Text _playerScoreText;
    private Text _playerLivesText;

    public SpawnCharacter SpawnCharacter;
    
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);

        SpawnCharacter = GameObject.FindObjectOfType<SpawnCharacter>();
        _playerLivesObj = GameObject.Find("Lives");
        _playerLivesText = _playerLivesObj.GetComponent<Text>();
        _playerLivesText.text = "Lives: " + SpawnCharacter.NumOfLives;
    }

    public void UpdateScoreText(int score)
    {
        _playerScoreText.text = "Score: " + score;
    }

    public void UpdatePlayerLivesText(int lives)
    {
        _playerLivesText.text = "Lives: " + lives;
    }

    public void DisplayGameOver(){
        GameOverText.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
