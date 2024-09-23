using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherball : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    //1.물리적 충돌이 시작할 때 호출되는 함수 
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "MyBall")
        mat.color = new Color(0,0,0);
    }
    //2.물리적 충돌중 일 때 호출되는 함수
    /* private void OnCollisionStay(Collision collision) {
        
    }
    //3.물리적 충돌이 끝났을 때 호출되는 함수
    private void OnCollisionExit(Collision collision) {
        
    } */
}
