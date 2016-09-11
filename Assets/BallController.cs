using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    //ボールが見える可能性のあるｚ軸の最大値
    private float visidlePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

	// Use this for initialization
	void Start () {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");//←Findで作ったオブジェクトを拾ってる
	

    }
	
	// Update is called once per frame
	void Update () {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.visidlePosZ) {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

	
	}
}
