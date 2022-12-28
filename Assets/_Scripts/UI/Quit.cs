using UnityEngine;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    private Button _quitButton;

    void Start()
    {
        _quitButton = GetComponent<Button>();
        _quitButton.onClick.AddListener(Quitting);
    }
    private void Quitting()
    {
        Application.Quit();
    }
}
