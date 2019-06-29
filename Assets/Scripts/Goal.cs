using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	void OnTriggerEnter(Collider col_obj) {

		// Resorcesフォルダ下にあるGoalEffectのPrefabを読み込む
		GameObject prefab = (GameObject)Resources.Load ("GoalEffect");
		
		if(prefab != null){
			// 座標値0
			Vector3 create_shoter_vec = new Vector3(0,0,0);

			//オブジェクトを作ると破棄.
			GameObject instant_object = (GameObject) GameObject.Instantiate(prefab,create_shoter_vec, Quaternion.identity);
			
			// 削除までの時間
			Destroy(instant_object,3);
		}
		
	}
}
