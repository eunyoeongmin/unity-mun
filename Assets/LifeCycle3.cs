using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        /* //1.MoveTowards
        transform.position = 
            Vector3.MoveTowards(transform.position
                            , target, 2f); */

        /* //2.SmoothDamp
        Vector3 velo = Vector3.zero;

        transform.position = 
            Vector3.SmoothDamp(transform.position
                            , target, ref velo, 0.1f); */

        /* //3.Lerp (선형 보간)
        transform.position = 
            Vector3.Lerp(transform.position
                            , target, 0.05f); */

        //4.Slerp (구면 선형 보간)
        transform.position = 
            Vector3.Slerp(transform.position
                            , target, 0.005f);
    }
}
