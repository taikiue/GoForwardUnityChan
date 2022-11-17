using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;

    // ���ňʒu
    private float deadLine = -10;

    //�n�ʂ̈ʒu
    private float groundLevel = -3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
            {
                Destroy(gameObject);
            }
    }

    //���ʉ��̏Փ˔���
    private void OnCollisionEnter2D(Collision2D other)
    {
        //cube���n�ʂ�cube�ɏՓ˂����Ƃ�����炷
        if(other.gameObject.tag == "GroundTag" || other.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
        /*UnityChan��cube�ƏՓ˂����Ƃ������Ǝ~�߂�
        else if(other.gameObject.tag == "UnityChantag")
        {
            GetComponent<AudioSource>().Stop();

        }*/
    }
}
