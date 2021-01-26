using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacia : MonoBehaviour {
	public Transform target; // objekt, okolo ktoreho sa bude rotovat
	public int speed; // rychlost rotacie

	void Start() {
		// ak nemame definovany objekt pre rotaciu, pojde sam okolo seba
		if (target == null) target = this.gameObject.transform;
	}

	void Update () {
		// rotuje sa okolo target.transform.position
		// vektor / smer rotácie, resp. os okolo ktorej sa rotuje / up, right
		// uhol sa meni v zavislosti od casu a rychlosti
		transform.RotateAround(target.transform.position,target.transform.up,
			speed * Time.deltaTime);
	}

}
