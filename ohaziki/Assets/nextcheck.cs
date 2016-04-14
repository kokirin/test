using UnityEngine;
using System.Collections;

public class nextcheck : MonoBehaviour {
	public int crashcount = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void checkcrash(){
		Debug.Log ("test");
		crashcount ++;
	}
}
