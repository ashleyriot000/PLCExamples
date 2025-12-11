using System;
using UnityEngine;
using UnityEngine.UI;

public class InverterDisplayer : MonoBehaviour
{
    public InverterController controller;
    public Text currentHz;
    public Text currentDirection;    

    void Update()
    {
        //Mathf.Abs(값) 절대값을 구하는 함수. 음수든 양수든 모두 양수로 변환해줌.
        //ToString("표현식") 모든 값을 문자열로 변환시켜줌. F1 : 실수 표현 숫자만큼 소수점아래 표시.
        //D5 : 5자리수보다 작은 수의 경우 앞에 부족한 자릿수만큼 0을 채워줌.
        currentHz.text = Mathf.Abs(controller.GetCurrentHZ).ToString("F1") + "Hz";
        currentDirection.text = $"{(controller.STF ? "STF" : "")}\n{(controller.STR ? "STR" : "")}";        
    }
}
