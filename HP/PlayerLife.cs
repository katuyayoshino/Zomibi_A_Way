using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Player life.
/// </summary>

public class PlayerLife : MonoBehaviour 
{
	//プレイヤーの最大HP
	public readonly float maxLife = 100;
	//初期体力
	public float life = 100;

	void Start () 
	{
		//体力を初期化
		life = maxLife;
	}

	void Update () 
	{
		if(life <= 0)
		{
			//体力が0になったらDeadを呼び出す
			Dead();
		}
	}

	public void Damage (float damage) 
	{
		//体力が減る
		life -= damage;
	}

	//死亡処理（死亡時の演出）
	public void Dead () 
	{
		//ゲームオーバーにする
		GameOver(); 
	}

	//ゲームオーバー処理
	public void GameOver () 
	{
		//シーンの再読み込み//後で直す
		Application.LoadLevel ("End");
	}
	//体力を表示//trueの時体力を表示させる
	public bool flag = true;    

	//UIに体力の数字を表示
	void OnGUI ()
	{
		if (flag) 
		{
			GUI.Label (new Rect (20, 300, 100, 300), "Life " + life);
		}
	}



}
