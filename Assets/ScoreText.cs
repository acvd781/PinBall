using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;
    private int score = 0;
    private string tags;

	// Use this for initialization
	void Start () {
        //初期表示
        scoreText.text = "Score:0";

	}
	
	// Update is called once per frame
	void Update () {
        //表示されてるスコアにscore変数の数字を付け足す
        scoreText.text = "Score:"+score;

	}
    //オブジェクトに当たった時の加算判定
    void OnCollisionEnter(Collision col) {
        tags = col.gameObject.tag;
        if (tags == "SmallStarTag") {
            score += 10;
        } else if (tags == "LargeStarTag") {
            score += 20;
        } else if (tags == "SmallCloudTag") {
            score += 15;
        } else if (tags == "LargeCloudTag") {
            score += 100;
        }
    }
}
