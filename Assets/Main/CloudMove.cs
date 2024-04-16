using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{

    public Transform centerOfRotation; // 中心旋转物体的Transform组件
    public float speed = 100.0f; // 旋转速度
    Vector3 tr;
    void Start()
    {
        tr = new Vector3(centerOfRotation.position.x, transform.position.y, centerOfRotation.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // 以centerOfRotation为中心，绕Y轴旋转
        transform.RotateAround(tr, Vector3.up, speed * Time.deltaTime);

    }


}
