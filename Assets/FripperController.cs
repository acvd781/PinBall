using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour {

    //HingeJointコーポネントを入れる
    private HingeJoint myHingeJoynt;

    //初期の傾き
    private float defaultAngle = 20;
    //弾いた時の傾き
    private float flickAngle = -20;

	// Use this for initialization
	void Start () {
        //HingeJointコーポネント取得
        this.myHingeJoynt = GetComponent<HingeJoint>();

        //フリッパーの傾きを設定
        SetAngle(this.defaultAngle);
	
	}

    // Update is called once per frame
    void Update(){

        //左矢印キーを押した時左フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag") {
            SetAngle(this.flickAngle);
        }
        //右矢印キーを押した時右フリッパーを動かす
        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag") {
            SetAngle(this.flickAngle);
        }
        //矢印キーが話された時にフリッパーを元に戻す
        if (Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.RightArrow)){
            SetAngle(this.defaultAngle);
        }

    }
    //フリッパーの傾きを設定
    public void SetAngle(float angle){
        JointSpring jointspr = this.myHingeJoynt.spring;
        jointspr.targetPosition = angle;
        this.myHingeJoynt.spring = jointspr;
    }

}
