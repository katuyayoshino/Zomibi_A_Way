using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Clear scene.
/// </summary>

public class ClearScene : MonoBehaviour 
{

	public void ButtonPush()
	{
		Application.LoadLevel ("Title");
	}
}
