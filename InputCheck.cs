using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Input check.
/// </summary>

public class InputCheck : MonoBehaviour
{
	Camera MainCamera;//メインカメラ
	Camera DroneCamera;//サブのカメラです
	/// <summary>加速度？傾き？</summary>
	private Vector3 acceleration;
	/// <summary>フォント</summary>
	private GUIStyle labelStyle;

	// Use this for initialization
	void Start()
	{
		//フォント生成
		this.labelStyle = new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 22;
		this.labelStyle.normal.textColor = Color.white;
		//camera
		MainCamera = Camera.main.GetComponent<Camera>();
		DroneCamera = GameObject.Find ("DroneCamera").GetComponent<Camera> ();
		//DroneCamera.enabled = false;//ドローンカメラを停止させます
	}

	// Update is called once per frame
	void Update()
	{
		Debug.Log (acceleration.y);
		//文字描画はOnGUIでしかできないらしいので保持
		this.acceleration = Input.acceleration;
		//
		if (acceleration.y < 0.7f) {
			MainCamera.enabled = true;
			DroneCamera.enabled = false;
		} else {
			MainCamera.enabled = false;
			DroneCamera.enabled = true;
			Debug.Log("縦だよ");
		}


		if (acceleration != null)
		{
			float x = Screen.width / 10;
			float y = 0;
			float w = Screen.width * 8 / 10;
			float h = Screen.height / 20;

			for (int i = 0; i < 3; i++)
			{
				y = Screen.height / 10 + h * i;
				string text = string.Empty;

				switch (i)
				{
				case 0://X
					text = string.Format("accel-X:{0}", System.Math.Round(this.acceleration.x, 3));
					break;
				case 1://Y
					text = string.Format("accel-Y:{0}", System.Math.Round(this.acceleration.y, 3));
					break;
				case 2://Z
					text = string.Format("accel-Z:{0}", System.Math.Round(this.acceleration.z, 3));
					break;
				default:
					throw new System.InvalidOperationException();
				}

				GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
			}
		}

	}
}









