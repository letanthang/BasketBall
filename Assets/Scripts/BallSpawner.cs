using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	// Use this for initialization
	public GameObject ballPrefab;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float speed = 15.0f;

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.left * speed;				
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.right * speed;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			//print (transform.position);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.forward * speed;

			print (rb.velocity);

		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			rb.velocity = Vector3.back * speed;
		}
	}
}
