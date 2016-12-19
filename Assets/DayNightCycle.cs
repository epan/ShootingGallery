using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (new Vector3 (3f * Time.deltaTime, 0f, 0f));

//        Vector3 eulerRot = this.transform.rotation.eulerAngles;
//        eulerRot.x += 3f * Time.deltaTime;
//        this.transform.rotation = Quaternion.Euler(eulerRot);
	}
}
