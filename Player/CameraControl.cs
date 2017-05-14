using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Camera control.
/// </summary>

public class CameraControl : MonoBehaviour 
{
	private GameObject player=null;
	private Vector3 position_offset=Vector3.zero;
	/*
	void Update () 
	{
		//回転のロジック(試し)
		Time.deltaTime

		if (Input.GetMouseButtonUp (0)) 
		{
			this.transform.Rotate (00.0f, 180.0f, 0.0f);
			Debug.Log("回転中!!");
		}
		Input.GetKeyUp (KeyCode.Space)
		if (Input.GetKeyUp (KeyCode.Space)) 
		{
			this.transform.Rotate (00.0f, 180.0f, 0.0f);
			Debug.Log("回転中!!");
		}


	}
	*/
	public void OnClick() 
	{
		Debug.Log("回転中!!");
		this.transform.Rotate (00.0f, 180.0f, 0.0f);
	}
}
