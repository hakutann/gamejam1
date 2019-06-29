using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refrect : MonoBehaviour
{

    // Update is called once per frame
    void Update(){
        Vector3 v = new Vector3(0f, 0f, 3f);
        transform.Rotate(v);
    }

    void OnTriggerEnter(Collider col_obj) {
		//if(col_obj.gameObject.tag == "Ball") {
			GameObject o = col_obj.gameObject;
			Vector3 ball_vec = new Vector3(0.0f,Random.Range(15.0f, 25.0f),0.0f);
			
			o.GetComponent<Rigidbody>().velocity = ball_vec;
		//}

	}
}
