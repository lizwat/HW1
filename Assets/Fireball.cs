using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour {
	public float speed = 10.0f;
	public int damage = 1;

	void Update() {
		transform.Translate(0, 0, speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other) {
		PlayerCharacter player = other.GetComponent<PlayerCharacter>();
		ReactiveTarget enemy = other.GetComponent<ReactiveTarget>();
		Rigidbody body = other.attachedRigidbody;
		body.velocity = this.transform.forward*5;
		if (player != null) {
			player.Hurt(damage);
		}
		/**else if (enemy != null)
        {
			enemy.ReactToHit();
        } **/
		Destroy(this.gameObject);
	}

}
