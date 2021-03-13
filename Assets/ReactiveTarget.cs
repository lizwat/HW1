using UnityEngine;
using System.Collections;

public class ReactiveTarget : MonoBehaviour {
	private int kill = 0;
	public Vector3 deathPos;
	[SerializeField] private GameObject tombPrefab;
	private GameObject _tomb;
	private float speed = 100;
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	private int numKills;


	public void ReactToHit() {
		WanderingAI behavior = GetComponent<WanderingAI>();
		if (behavior != null) {
			behavior.SetAlive(false);
		}
		StartCoroutine(Die());

	}

	private IEnumerator Die() {

		kill += 1;

		for (var i = 0; i < 5; i++)
        {
			this.transform.Rotate(new Vector3(-9, 0, 0));
			yield return new WaitForSeconds(0.2f);
        }
		deathPos = this.gameObject.transform.position;
		yield return new WaitForSeconds(0.5f);
		
		Destroy(this.gameObject);
		_tomb = Instantiate(tombPrefab) as GameObject;
		_tomb.transform.position = deathPos;



	}

	public int getKills()
    {
		return kill;
    }

	public Vector3 getDeathPos()
    {
		return deathPos;
    }

	void Update()
    {
		_tomb.transform.Rotate(new Vector3(0.0f, speed * Time.deltaTime, 0.0f));

	}
}

