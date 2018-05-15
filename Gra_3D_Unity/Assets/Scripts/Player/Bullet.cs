using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private float timer = 0.0f;

	void Update() {
		timer += Time.deltaTime;
		if(timer > 4.0f) {
			Destroy(gameObject);
		}
	}

}
