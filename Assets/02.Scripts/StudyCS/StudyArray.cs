using UnityEngine;

public class StudyArray : MonoBehaviour {
    public int[] arrayNumber = new int[5] { 1, 2, 3, 4, 5 };


    void Start() {
        Debug.Log($"Array의 첫 번째 값 : {arrayNumber[0]}");
        Debug.Log($"Array의 두 번째 값 : {arrayNumber[1]}");
        Debug.Log($"Array의 여섯 번째 값 : {arrayNumber[6]}");
    }
}
