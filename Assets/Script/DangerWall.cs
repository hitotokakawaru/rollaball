using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour {

//オブジェクトと接触したときに呼ばれるコールバック
void OnCollisionEnter(Collision hit)
    {
        //接触したときに呼ばれるコールバック
        if (hit.gameObject.CompareTag("Player"))
        {

            //現在のシーン番号を取得
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;

            //現在のシーンを再度読み込みする
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
