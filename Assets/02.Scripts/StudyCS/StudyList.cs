using System;
using System.Collections.Generic;
using UnityEngine;

public class StudyList : MonoBehaviour {

    List<int> listNumber = new List<int>();

    void Start() {
        listNumber.Add(1);
        listNumber.Add(2);
        listNumber.Add(3);
        listNumber.Add(4);
        listNumber.Add(5);

        Debug.Log($"���� List�� �ִ� ������ �� : {listNumber.Count}");

        Debug.Log($"���� List�� ������ ������ : {listNumber[listNumber.Count - 1]}");
    }
}
