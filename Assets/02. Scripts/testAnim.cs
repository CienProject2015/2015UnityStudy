using UnityEngine;
using System.Collections;

public class testAnim : MonoBehaviour {
	
	private float h, v;
	
	public Animation _animation;
	
	private bool shoot = false;
	private bool bulletShoot = false;
	private float shootTimer = 0;
	
	void Update () {
		if(Input.GetKey("w")||Input.GetKey("s")){
			_animation.CrossFade("walk", 0.3f);
		}else{
			if(shoot){
				if(!_animation.isPlaying){
					shoot = false;
				}
			}else{
				_animation.CrossFade("stand", 0.3f);
				//_animation.clip = anim.stand;
				//_animation.Play();
			}
		}

	}
	
	
	
}

[System.Serializable]
public class Anim{
	public AnimationClip walk, stand, shoot;
}