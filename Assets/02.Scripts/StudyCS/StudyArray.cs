using UnityEngine;

public class StudyArray : MonoBehaviour {
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };


    void Start() {
        Debug.Log($"Array�� ù ��° �� : {arrayNumber[0]}");
        Debug.Log($"Array�� �� ��° �� : {arrayNumber[1]}");
        Debug.Log($"Array�� ���� ��° �� : {arrayNumber[6]}");
    }
}
