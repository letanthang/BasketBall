using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space)) {
//			print ("Yeap");
			NextScene ();
		}
	}

	void NextScene() {
		int currentIndex = SceneManager.GetActiveScene ().buildIndex;
		print ("Current Index: " + currentIndex);
		SceneManager.LoadScene (currentIndex + 1);
	}
}
