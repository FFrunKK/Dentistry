using System.Collections.Generic;
using Michsky.MUIP;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    
    // [SerializeField] private Button _patientBtn;
    [SerializeField] private ButtonManager _doctorBtn;
    [SerializeField] private ButtonManager _scheduleBtn;
    [SerializeField] private ButtonManager _statisticBtn;
    [SerializeField] private ButtonManager _menuBtn;
    [SerializeField] private ButtonManager _patientBtn;

    [SerializeField] private GameObject _doctorGO;
    [SerializeField] private GameObject _patientGO;
    [SerializeField] private GameObject _statisticGO;
    [SerializeField] private GameObject _sheduleGO;
    [SerializeField] private GameObject _mainGO;

    [SerializeField] private List<GameObject> _gameObjectList = new List<GameObject>();

    private void Awake() {
        _patientBtn.onClick.AddListener(() => {
            ShowUI(_patientGO);
        });
        _doctorBtn.onClick.AddListener(() => {
            ShowUI(_doctorGO);
        });
        _scheduleBtn.onClick.AddListener(() => {
            ShowUI(_sheduleGO);
        });
        _statisticBtn.onClick.AddListener(() => {
            ShowUI(_statisticGO);
        });
        _menuBtn.onClick.AddListener(() => {
            ShowUI(_mainGO);
        });
    }

    private void ShowUI(GameObject openUI) {
        for (int i = 0; i < _gameObjectList.Count; i++) {
            _gameObjectList[i].SetActive(false);
        }
        openUI.SetActive(true);
    }
}
