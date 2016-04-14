using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {
	public int Scene;
	private bool initializedflg;






	// Use this for initialization
	void Start () {
		Scene = 0;
		initializedflg = false;
	}
	public void Initialized(){
		Scene = 1;
		initializedflg = true;
	}

	// Update is called once per frame
	void Update () {
		if ( !initializedflg ) {
			Initialized();
		}


	
	}

	public SceneChanger( int Scene ){
		switch( Scene ){
			case 1:

				break;
			case 2:

				break;
			case 3:
				
				break;
			case 4:
				
				break;
			default:
				
				break;


		}
	}



}
