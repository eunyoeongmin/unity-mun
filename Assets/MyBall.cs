using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //#1. 속력 바꾸기
        //rigid.velocity = Vertor3.forward;

        //#2. 힘 가하기 
        if(Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")   
        );

        rigid.AddForce(vec, ForceMode.Impulse);

        //#3. 회전력 
        // rigid.AddTorque(Vector3.down);
    }
}
