﻿using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {
	public GameObject TouchObject;
	public GameObject OldTouchObject;
	public Vector3	  ControlPosition;
	private int raylayermask = 1 << 8;
	public	bool flowflg;

	public GameObject RayHiter;

	public GameObject testbox;

	public 		Ray cameraray;
	public		RaycastHit cameraraycasthit;
	public		bool ButtonUpSendflg = false;




	// Use this for initialization
	void Start () {
		flowflg = false;
	}
	
	// Update is called once per frame
	void Update () {
		TouchCheck ();
	}

	public void TouchCheck(){



		#if UNITY_IPHONE
		if( Input.touchCount > 0 ){
			Touch touch = Input.getTouch( 0 );
			if( touch.phase == TouchPhase.Began ){
				ControlPosition = touch.position;
				cameraray = Camera.main.ScreenPositionToRay( ControlPosition );
				if( Physics.Raycast( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
					TouchObject = cameraraycasthit.collider.gameObject;
					flowflg = true;
				}
			}
			else if( touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary ){
				ControlPosition = touch.position;
			}
			else{
				flowflg = false;
			}
		}
		#endif


		#if UNITY_EDITOR
		if( Input.GetMouseButton ( 0 ) ){
			ControlPosition = Input.mousePosition;
			flowflg = true;
		}

		if( Input.GetMouseButtonDown( 0 ) ){


			//cameraray
			//Debug.Log ( "InputLeft" );
			ControlPosition = Input.mousePosition;
			cameraray = Camera.main.ScreenPointToRay( ControlPosition );
			if( Physics.Raycast ( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
				RayHiter = cameraraycasthit.collider.gameObject;
				flowflg = true;
			}

			//flowflg = true;
			/*
			ControlPosition.x = ControlPosition.x;
			ControlPosition.z = ControlPosition.y;
			ControlPosition.y = -50.0f;
*/
			//ControlPosition.z = Camera.main.transform.position.y;

			//Debug.Log( ControlPosition );
			//Camera.main.ScreenToWorldPoint(clickPosition)
			//cameraray = Camera.main.ScreenPointToRay( ControlPosition );



			//cursor.z = Camera.main.transform.position.y
		}
		if( Input.GetMouseButtonUp( 0 ) ){
			ButtonUpSendflg = true;
			flowflg = false;

		}
		#endif
		/*

		cameraray = Camera.main.ScreenPointToRay( ControlPosition );
		
		if( Physics.Raycast ( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
			if( flowflg ){
				//Debug.Log( cameraraycasthit.collider.gameObject.name );
				if( cameraraycasthit.collider.gameObject.ToString().Contains( "medal" ) ){
					cameraraycasthit.collider.gameObject.GetComponent<medal>().MakeObject();
				}
				TouchObject = cameraraycasthit.collider.gameObject;
				if( Physics.Raycast ( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
					if( cameraraycasthit.collider.gameObject.ToString().Contains( "BumpObject" ) ){
						Debug.Log( "test" );
						cameraraycasthit.collider.gameObject.GetComponent<BumpObject>().UpDataPosition(  );
					}
				}

			//Instantiate( testbox, ControlPosition, Quaternion.identity );
			//flowflg = true;
			}
		}
		*/
		/*
		if ( !cameraraycasthit.collider.gameObject == null ) {
			if ( cameraraycasthit.collider.ToString ().Contains ("medal") ) {
				//cameraraycasthit.collider.GetComponent<>()
				Debug.Log (cameraraycasthit.collider.ToString());
			}
		}
		*/

		if( flowflg ){
			if( RayHiter.ToString().Contains( "medal" ) ){
				Vector3 test;
				test = Camera.main.ScreenToWorldPoint( new Vector3( ControlPosition.x, ControlPosition.y, 50.0f ) );
				//RayHiter.GetComponent<medal>().MakeObject( test );
				if( Physics.Raycast ( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
					RayHiter = cameraraycasthit.collider.gameObject;
				}
				//cameraraycasthit.collider.gameObject.GetComponent<medal>().MakeObject( test );
			}
			/*
			if( RayHiter.ToString().Contains( "BumpObject" ) ){
				Vector3 test;
				test = Camera.main.ScreenToWorldPoint( new Vector3( ControlPosition.x, ControlPosition.y, 50.0f ) );
				RayHiter.GetComponent<BumpObject>().UpDataPosition( test );

			}
			*/


		}

		if( ButtonUpSendflg ){
			Vector3 test;
			test = Camera.main.ScreenToWorldPoint( new Vector3( ControlPosition.x, ControlPosition.y, 50.0f ) );

			//RayHiter.GetComponent<medal>().MakeObject( test );
			/*
			if( Physics.Raycast ( cameraray.origin, cameraray.direction, out cameraraycasthit, Mathf.Infinity, raylayermask ) ){
				RayHiter = cameraraycasthit.collider.gameObject;
			}
*/
			//

			RayHiter.GetComponent<medal>().MoveOrigin( test );
			ButtonUpSendflg = false;

		}




	}





}
