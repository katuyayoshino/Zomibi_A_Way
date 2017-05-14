using UnityEngine;
using System.Collections;

/// <summary>
/// Jibakubotann.
/// </summary>

public class jibakubotann: MonoBehaviour 
{
	
	public void OnClick() {
		Application.LoadLevel ("End");
		Debug.Log("Button click!");
	}

}