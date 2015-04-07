using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class FireCtrl : MonoBehaviour
{

	public GameObject bullet;
	public Transform firePos;
	public AudioClip fireSfx;
	private AudioSource audio = new AudioSource ();
	public MeshRenderer _renderer;
	// Use this for initialization
	void Start ()
	{
		audio = GetComponent<AudioSource> ();
		_renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButton (0)) {
			Fire ();
		}
	}

	void Fire ()
	{
		StartCoroutine (this.ShowMuzzleFlash ());
		StartCoroutine (this.CreateBullet ());
		StartCoroutine (this.PlaySfx (fireSfx));
	}

	IEnumerator ShowMuzzleFlash ()
	{
		_renderer.enabled = true;

		float _scale = Random.Range (1.0f, 2.0f);
		_renderer.transform.localScale = Vector3.one * _scale;

		Quaternion rot = Quaternion.Euler (0, 0, Random.Range (0, 360));
		_renderer.transform.localRotation = rot;

		yield return new WaitForSeconds (Random.Range (0.01f, 0.2f));

		_renderer.enabled = false;
	}

	IEnumerator CreateBullet ()
	{
		Instantiate (bullet, firePos.position, firePos.rotation);
		yield return null;
	}

	IEnumerator PlaySfx (AudioClip _clip)
	{
		audio.PlayOneShot (_clip, 0.9f);
		Debug.Log ("test");
		yield return null;
	}
}
