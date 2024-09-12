using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifrCycle2 : MonoBehaviour
{
    void Start()
    {   
        
      
    }

     void Update() {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
            ,0); // 벡터 값 = 방향 값 
        transform.Translate(vec);
    }

}
