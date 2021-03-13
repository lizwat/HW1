using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	private int numKills;
	

	void Start()
    {
		spawnEnemy();
    }
	
	void spawnEnemy()
    {
		enemyPrefab = Resources.Load("MachineGunRobot") as GameObject;
		_enemy = Instantiate(enemyPrefab) as GameObject;
		_enemy.transform.position = new Vector3(0, 1, 0);
		float angle = Random.Range(0, 360);
		_enemy.transform.Rotate(0, angle, 0);

	}
	
	void Update() {

        if (_enemy == null) 
		{
			numKills += 1;
			for (var i = 0; i <= numKills; i++)
			{
				spawnEnemy();
			}
		}
    } 
		
	}
