using UnityEngine;
using System.Collections;

public class TestPlayerCtrl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Input.GetAxis ("Vertical");
	}
}
