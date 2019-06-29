//失敗

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    public float interval = 6f;
    private float timeElapsed = 0;
    bool flag = true;

    // Start is called before the first frame update
    void Start(){
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update(){
        timeElapsed += Time.deltaTime;

        if(timeElapsed>=interval){
            if(flag){
                GetComponent<Renderer>().material.color = Color.black;
                flag = false;   //
            }else{
                GetComponent<Renderer>().material.color = Color.white;
                flag = true;    //
            }
            timeElapsed = 0;
        }

        if(!flag && Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log("Miss!");
        }


    }
}
/*
public class Quad : MonoBehaviour
{
    public float interval = 6f;
    private float timeElapsed = 0;
    bool flag = true;
    public Texture texture = (Texture)Resources.Load("Ghost.image");

    // Start is called before the first frame update
    void Start(){
        GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update(){
        timeElapsed += Time.deltaTime;

        if(timeElapsed>=interval){
            if(flag){
                GetComponent<Renderer>().material.mainTexture = texture;
                texture.Apply();
                flag = false;   //お化けが出る
            }else{
                GetComponent<Renderer>().material.color = Color.white;
                flag = true;    //お化けがいなくなる
            }
            timeElapsed = 0;
        }

        if(!flag && Input.GetKeyDown(KeyCode.Space)){
            //Debug.Log("Miss!");
        }


    }
}
*/