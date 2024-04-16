using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{

    public Transform centerOfRotation; // ������ת�����Transform���
    public float speed = 100.0f; // ��ת�ٶ�
    Vector3 tr;
    void Start()
    {
        tr = new Vector3(centerOfRotation.position.x, transform.position.y, centerOfRotation.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // ��centerOfRotationΪ���ģ���Y����ת
        transform.RotateAround(tr, Vector3.up, speed * Time.deltaTime);

    }


}
