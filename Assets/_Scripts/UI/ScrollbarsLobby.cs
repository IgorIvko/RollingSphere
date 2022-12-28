using UnityEngine;
using UnityEngine.UI;

public class ScrollbarsLobby : MonoBehaviour
{
    [SerializeField] private Scrollbar _sensitivity_Y;
    [SerializeField] private Scrollbar _sensitivity_X;

    private void Awake()
    {
        _sensitivity_Y.value = MoverAxel.speed / 100f;
        _sensitivity_X.value = MoverAxel.speedY / 100f;
    }
    
    void Start()
    {
        _sensitivity_Y.onValueChanged.AddListener(ChangeMoverSpeed_Y);
        _sensitivity_X.onValueChanged.AddListener(ChangeMoverSpeed_X);
    }

    private void ChangeMoverSpeed_Y(float value)
    {
        MoverAxel.speed = _sensitivity_Y.value * 50f;
    }

    private void ChangeMoverSpeed_X(float value)
    {
        MoverAxel.speedY = _sensitivity_X.value * 50f;
    }
}
