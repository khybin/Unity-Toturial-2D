using UnityEngine;

public class Calculator : MonoBehaviour {

    public int number1, number2;

    void Start() {
        int addResult = AddMethod(); // �Լ� ȣ��
        int minusResult = MinusMethod(); // �Լ� ȣ��

        Debug.Log($"���� �� : {addResult}, �� �� : {minusResult}");
    }

    // �� ������ ���ϴ� �Լ�
    int AddMethod() {
        // �������� result
        int result = number1 + number2;
        return result; // result�� ��ȯ
    }
    // �� ������ ���� �Լ�
    int MinusMethod() {
        // �������� result
        int result = number1 - number2;
        return result; // result�� ��ȯ
    }
}
