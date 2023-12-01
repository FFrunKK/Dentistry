using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    
    [SerializeField] private Button _patientBtn;
    [SerializeField] private Button _doctorBtn;
    [SerializeField] private Button _scheduleBtn;
    [SerializeField] private Button _statisticBtn;
    [SerializeField] private Button _menuBtn;

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
