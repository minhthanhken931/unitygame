using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject _enemypre;

    [SerializeField]
    private GameObject _playerpre;

    [SerializeField]
    private float _spawnTime = 1f;
    [SerializeField]
    private Text _scoreUI;
    private float _score;

    void Start()
    {
        Instantiate(_playerpre, new Vector3(0f, -4f, -2f), Quaternion.identity);
        Invoke("SpawnEnemies", _spawnTime);
    }
    void SpawnEnemies()
    {
        Instantiate(_enemypre, new Vector3(Random.Range(-2.4f,2.4f),transform.position.y,transform.position.z) ,Quaternion.identity);
        Invoke("SpawnEnemies",  _spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        _score++;
        _scoreUI.text = " Score: " + _score.ToString();
    }
}
