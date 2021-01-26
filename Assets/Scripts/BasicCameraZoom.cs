using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCameraZoom : MonoBehaviour {
	public float maxCamDistance = 20f;
	public float minCamFOV = 50f;
	public float zoom = 100f;

	public Transform target;
	public Camera myCam;
	float initialFOV;

	public AudioSource a;


	// Use this for initialization
	void Start () {
		myCam = this.GetComponent<Camera> ();
		initialFOV = myCam.fieldOfView;
	}
	void ResetFOV(){
		myCam.fieldOfView = initialFOV;
	}


	// Update is called once per frame
	void LateUpdate() {
		if (Input.GetMouseButtonDown (0)) {
			
			Ray ray = myCam.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				//zoom = !zoom;
				target = hit.transform;
				Info_planet.nazov = target.name;
				a = target.GetComponent<AudioSource> ();
				a.Play ();
				//Debug.Log ("KLIK");
				if (target == null) {
					ResetFOV ();
					//Debug.Log ("TARGET NULL");
				} else {

					myCam.transform.LookAt (target);
					//Debug.Log ("ZOOM");
					if (Vector3.Distance (transform.position, target.position) > maxCamDistance) {
						if (myCam.fieldOfView <= minCamFOV) {
							myCam.fieldOfView = minCamFOV;
							//ResetFOV ();
							//Debug.Log ("MINCAM");
						} else {
							myCam.fieldOfView -= zoom;
							//Debug.Log ("-FOVSPEED");
						}
					}
				}
			}
		}
		if (Input.GetMouseButtonDown (1)) {
			ResetFOV();
			AudioSource[] audios = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
			foreach (AudioSource aud in audios)
				aud.Stop ();
		}
		myCam.transform.LookAt(target.transform);
	}
}		