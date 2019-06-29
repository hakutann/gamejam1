using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject prefab = null;
            Vector3 create_shoter_vec = new Vector3(2.2f,-4.7f,-0.3f);//ボールの生成位置

            prefab = (GameObject)Resources.Load("Ball");

            if(prefab!=null){
                GameObject clone_ball=(GameObject)GameObject.Instantiate(prefab,create_shoter_vec,Quaternion.identity);

                Vector3 ball_vec = new Vector3(0.0f,20.0f,0.0f);//ボールの速度設定

                clone_ball.GetComponent<Rigidbody>().velocity=ball_vec;
            }
        }
    }
}
