using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameUI : MonoBehaviour {
	public Text txtScore;
	private int totscore = 0;
	// Use this for initialization
	void Start () {
		totscore = PlayerPrefs.GetInt ("TOT_SCORE", 0);
		DispScore (0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DispScore(int score){
		totscore += score;

		txtScore.text = "score <color=#ff0000>" + totscore.ToString () + "</color>";

		PlayerPrefs.SetInt ("TOT_SCORE", totscore);
	}
}
