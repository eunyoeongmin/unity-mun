using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifrCycle : MonoBehaviour
{
    /* void Awake() { //게임 오브젝트 생성할 때, 최초 실행


        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() { //게임오브젝트가 활성화 되었을 때 
        Debug.Log("플레이어가 로그인하였습니다.");
    }

    void Start() { //업데이트 시작 직전, 최초 실행
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() { //물리 연산 업데이트 CPU많이 씀 
        //Debug.Log("이동~");
    }

    void Update() { //게임 로직 업데이트 환경에 따라 실행주기 다름
        //Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() { //모든 업데이트 끝난 후 
        //Debug.Log("경험치 획득.");
    }

    private void OnDisable() { // 게임 오브젝트가 비활성화 되었을 때
        Debug.Log("플레이어가 로그아웃하였습니다");
    }

    void OnDestroy() { //게임 오브젝트가 삭제될때
        //Debug.Log("플레이어 데이터를 해제하였습니다.");
    } */
    void Update(){
        if(Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        /* if(Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다."); */

        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중.");

        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");


    }   

}
