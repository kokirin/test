using UnityEngine;
using System.Collections;

public class medal : MonoBehaviour {
	public GameObject MyObject;
	public GameObject BumpObject;

	public GameObject ChildObject;

	private int		  medaltype;

	public Vector3		Vec;

	public int		  Affiliation;

	public Color		mycolor;

	//public int			PlayerType;

	public GameObject turnchecker = null;


	// Use this for initialization
	void Start () {
		MyObject = gameObject;

		turnchecker = GameObject.Find( "nextturncheck" );

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	public void MakeObject( Vector3 test ){
		ChildObject =( GameObject )Instantiate ( BumpObject, gameObject.transform.position, Quaternion.identity );
		ChildObject.transform.parent = gameObject.transform;
		ChildObject.GetComponent<BumpObject> ().MakeMe ( gameObject.transform.position, MedalType );
		//Debug.Log ("test");
	}
	*/


	public void MoveOrigin( Vector3 pos ){
		Vector3 NomVec;
		NomVec = gameObject.transform.position - pos;
		NomVec = Vector3.Normalize( NomVec );
		Vec = NomVec * ( Vector3.Distance( gameObject.transform.position, pos ) * 100 );
		gameObject.rigidbody.AddForce (Vec);




	}

	public void MyColorChange(){
		switch ( medaltype ) {
			case 0:
				gameObject.renderer.material.color = Color.blue;
				break;
			case 1:
				gameObject.renderer.material.color = Color.red;
				break;

			case 2:
				gameObject.renderer.material.color = Color.green;
				break;

			case 3:
				gameObject.renderer.material.color = Color.yellow;
				break;
		}
		mycolor = gameObject.renderer.material.color;
	}

	public int MedalType{
		set{ medaltype = value; }
		get{ return medaltype; }

	}

	public Vector3 Pos{
		set{ gameObject.transform.position = value; }
		get{ return gameObject.transform.position; }
	}

	void OnCollisionEnter( Collision other ){
		//Debug.Log (other.collider.ToString());
		if ( other.collider.ToString().Contains( "medal" ) ) {
			turnchecker.GetComponent<nextcheck>().checkcrash();
		}
	}

	public void Colorchange( int turn ){
		if (turn == Affiliation) {
			gameObject.renderer.material.color = mycolor;
		}
		else {
			gameObject.renderer.material.color = Color.
		}
	}



}
