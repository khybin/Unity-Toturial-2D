using UnityEngine;

public class Calculator : MonoBehaviour {

    public int number1, number2;

    void Start() {
        int addResult = AddMethod(); // 함수 호출
        int minusResult = MinusMethod(); // 함수 호출

        Debug.Log($"더한 값 : {addResult}, 뺀 값 : {minusResult}");
    }

    // 두 변수를 더하는 함수
    int AddMethod() {
        // 지역변수 result
        int result = number1 + number2;
        return result; // result를 반환
    }
    // 두 변수를 빼는 함수
    int MinusMethod() {
        // 지역변수 result
        int result = number1 - number2;
        return result; // result를 반환
    }
}
