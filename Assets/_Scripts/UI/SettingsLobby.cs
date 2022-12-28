using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SettingsLobby : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _buttonText;
    [SerializeField] GameObject _settingsPanel;
    private Button _settingsButton;  
    void Start()
    {
        _settingsButton = GetComponent<Button>();
        _settingsButton.onClick.AddListener(ShowSettingsPanel);
    }
    private void ShowSettingsPanel()
    {
        if(_settingsPanel.activeSelf)
        {
            _settingsPanel.SetActive(false);
            _buttonText.text = "Settings";
        }
        else
        {
            _settingsPanel.SetActive(true);
            _buttonText.text = "Back";
        }
    }
}
