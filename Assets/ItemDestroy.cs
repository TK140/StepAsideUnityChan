using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
 {
    //Unityちゃんのオブジェクト	
    private GameObject unitychan;
    //UnityちゃんのＺ軸	
    private float unityichi;

    // Use this for initialization	
    void Start()
    {

        //Unityちゃんのオブジェクトを取得	
        unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame	
    void Update()
    {

        //Unityちゃんの座標Ｚを取得	
        unityichi = unitychan.transform.position.z;

        if (unityichi - 3 > this.transform.position.z)
        {
            Destroy(this.gameObject);

        }
    }
}

