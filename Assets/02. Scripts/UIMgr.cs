using UnityEngine;
using System.Collections;

public class UIMgr : MonoBehaviour {

	public void OnClickStartButton(RectTransform rt){
		Debug.Log ("Click Button" + rt.localScale.x.ToString ());
	}

}
