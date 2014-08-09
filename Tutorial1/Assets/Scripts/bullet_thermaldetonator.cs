using UnityEngine;
using System.Collections;

public class bullet_thermaldetonator : MonoBehaviour {
	
	float lifespan = 3.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan<= 0) {
				Explode();
		}
	}
	
	void OnCollisionEnter() {
		//Destroy(gameObject);
	}
		
	void Explode() {
			
			Destroy (gameObject);
	
	}
}
