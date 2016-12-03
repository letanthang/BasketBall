using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncreaseScore() {
		score += 1;
		print ("Score: " + score);
	}
}
