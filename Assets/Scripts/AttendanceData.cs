using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttendanceData : MonoBehaviour
{
    string attendanceName;
    string absences;
    string lates;
    string leftEarly;
    string noCallNoShow;
    string noCallLates;

    void UpdateData()
    {
        attendanceName = gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text;
        absences = gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        lates = gameObject.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        leftEarly = gameObject.transform.GetChild(3).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        noCallNoShow = gameObject.transform.GetChild(4).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;
        noCallLates = gameObject.transform.GetChild(5).gameObject.transform.GetChild(2).gameObject.GetComponent<Text>().text;
    }
}
