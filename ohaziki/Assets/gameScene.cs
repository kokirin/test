using UnityEngine;
using System.Collections;

public class gameScene : MonoBehaviour {


	public GameObject MyMedal;
	public GameObject EnemyMedal;
	public GameObject	MyChild;

	public int			status;

	public Vector3		MedalPosition;


	private bool Initializedflg = false;

	public int crashcount = 0;



	// Use this for initialization
	void Start () {

	
	}
	void Initialize(){
		for( int i = 0; i < 4; i ++ ){
			MedalPosition = new Vector3( -90.0f, -45.0f, -50.0f );
			MyChild = ( GameObject )Instantiate( MyMedal ); 

			MyChild.transform.parent = gameObject.transform;
			MyChild.GetComponent<medal>().MedalType = i;
			MedalPosition.x += 60 * i;
			MyChild.GetComponent<medal>().Pos = MedalPosition;
			MyChild.GetComponent<medal>().MyColorChange();
			MyChild.GetComponent<medal>().Affiliation = 1;

			MyChild.name = "Player1" + "Medal" + i;

			//MyChild = ( GameObject )Instantiate( EnemyMedal[ i ] );
			//MyChild.transform.parent = gameObject.transform;


		}

		for( int i = 0; i < 4; i ++ ){
			MedalPosition = new Vector3( -90.0f, -45.0f, 50.0f );
			MyChild = ( GameObject )Instantiate( MyMedal ); 

			MyChild.transform.parent = gameObject.transform;
			MyChild.GetComponent<medal>().MedalType = i;
			MedalPosition.x += 60 * i;
			MyChild.GetComponent<medal>().Pos = MedalPosition;
			MyChild.GetComponent<medal>().MyColorChange();
			MyChild.GetComponent<medal>().Affiliation = 2;
			MyChild.name = "Player2" + "Medal" + i;
			
			//MyChild = ( GameObject )Instantiate( EnemyMedal[ i ] );
			//MyChild.transform.parent = gameObject.transform;
			
			
		}

		status = 1;

		Initializedflg = true;
	}
	
	// Update is called once per frame
	void Update () {
		if ( !Initializedflg ) {
			Initialize();
		}

		turncheck ();

	}


	void turncheck(){
		switch ( status ) {
			//turnUnitlivecheck
		case 1:
			//if(  )
			break;
			//selectcheck
		case 2:

			break;
			//hazikinow
		case 3:
			break;
			//hitcheck
		case 4:
			break;
			//Players livecheck
		case 5:
			break;
		default:
			break;
		}

	}




}
