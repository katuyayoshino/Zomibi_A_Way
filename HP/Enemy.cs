using UnityEngine;
using System.Collections;

/// <summary>
/// 吉野勝也担当
/// Enemy.
/// </summary>

public class Enemy : MonoBehaviour 
{
	//敵の初期多力
	public float life = 30;


	public void Damage ( float damage ) 
	{
		//体力から差し引く
		life -= damage; 
		if(life <= 0)
		{
			//体力が0以下になった時//死亡処理
			Dead(); 
		}
	}

	//死亡処理
	public void Dead () 
	{ 
		Destroy(this.gameObject);   //自身を削除
	}

}
