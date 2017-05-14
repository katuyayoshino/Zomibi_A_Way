using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Titlescene.
/// </summary>

public class titlescene : MonoBehaviour 
{

	public void ButtonPush()
	{
		Application.LoadLevel("play");
	}
}
