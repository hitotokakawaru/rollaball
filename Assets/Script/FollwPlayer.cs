using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollwPlayer : MonoBehaviour {
    public Transform target; //ターゲットへの参照
    private Vector3 offset;//相対座標
	
    void Start()
    {
        //自分自身とtargetとの相対距離を求める
        offset = transform.position - target.position;
    }

    void Update()
    {
        //自分自身の座標に、targetの座標の相対座標を足した値を設定する
        transform.position = target.position + offset;
    }
}
