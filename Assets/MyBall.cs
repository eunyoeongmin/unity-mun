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
    void FixedUpdate()
    {
        //#1. 속력 바꾸기
        //rigid.velocity = Vertor3.forward;

        //#2. 힘 가하기 
        /* if(Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")   
        ); */

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h,0,v);


        rigid.AddForce(vec, ForceMode.Impulse);

        //#3. 회전력 
        // rigid.AddTorque(Vector3.down);
    }

    //트리거 콜라이더(물리x)가 계속 충돌하고 있을 때 호출.
    private void OnTriggerStay(Collider other) {
            if(other.name == "new cube")
                rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
}
