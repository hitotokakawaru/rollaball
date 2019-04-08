using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody rgbody;
    //speedを制御する
    public float speed = 10;

    public float jumpSpeed;
        private void Start()
    {
        //GameObjectが持つRigidBodyコンポーネントを取得
        rgbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump"))
        {
            rgbody.velocity = Vector3.up * jumpSpeed;
        }

        //rigidbodyのx軸（横）とz軸（奥）に力を加える
        rgbody.AddForce(moveHorizontal*10, 0, moveVertical*10);
    }

}