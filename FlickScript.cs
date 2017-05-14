using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Flick script.
/// </summary>

public class FlickScript : MonoBehaviour {

	Camera MainCamera;

	// Use this for initialization
	void Start () {
		MainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		if (Input.GetMouseButtonUp (0)) 
		{
			MainCamera.transform.Rotate(00.0f, 180.0f, 0.0f);
		}
		*/
	
	}

	public void ButtonPush()
	{
		MainCamera.transform.Rotate(00.0f, 180.0f, 0.0f);
	}
}
