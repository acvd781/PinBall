using UnityEngine;
using System.Collections;

public class BrightnessRegulator : MonoBehaviour {

    //Materialを入れる
    Material myMaterial;

    //Emissionの最小値
    private float minEmission = 0.3f;
    //Emissionの強度
    private float magEmission = 2.0f;
    //角度
    private int degree = 0;
    //発行速度
    private int speed = 10;
    //ターゲットのデフォルトの色
    Color defaultCloror = Color.white;

    //スコア用変数
    public int tuikascore = 0;

	// Use this for initialization
	void Start () {
        //タグによって光らせる色を変える
        if(tag == "SmallStarTag") {
            this.defaultCloror = Color.white;
        }else if(tag == "LargeStarTag"){
            this.defaultCloror = Color.yellow;
        }else if(tag == "SmallCloudTag" || tag == "LargeCloudTag") {
            this.defaultCloror = Color.blue;
        }

        //オブジェクトにアタッチしているMaterialを取得
        this.myMaterial = GetComponent<Renderer>().material;

        //オブジェクトの最初の色を設定
        myMaterial.SetColor("_EmissionColor", this.defaultCloror * minEmission);
    }
	
	// Update is called once per frame
	void Update () {
        if (this.degree >= 0) {
            //光らせる強度を計算する
            Color emissionColor = this.defaultCloror * (this.minEmission + Mathf.Sin(this.degree * Mathf.Deg2Rad) * this.magEmission);
            //エミッションに色を設定する
            myMaterial.SetColor("_EmissionColor", emissionColor);
            //現在の角度を小さくする
            this.degree -= this.speed;
        }
	
	}
    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other) {
        //角度を180に設定
        this.degree = 180;
    }
}
