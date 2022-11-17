using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    //地面の位置
    private float groundLevel = -3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
            {
                Destroy(gameObject);
            }
    }

    //効果音の衝突判定
    private void OnCollisionEnter2D(Collision2D other)
    {
        //cubeが地面とcubeに衝突したとき音を鳴らす
        if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
        /*UnityChanがcubeと衝突したとき音をと止める
        else if(other.gameObject.tag == "UnityChantag")
        {
            GetComponent<AudioSource>().Stop();

        }*/
    }
}
