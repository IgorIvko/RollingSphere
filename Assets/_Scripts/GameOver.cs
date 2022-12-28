using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private Button _yesButton;

    private void Start()
    {
        _yesButton.onClick.AddListener(EndLevel);
    }

    private void EndLevel()
    {
        Manager.Instance.ReloadScene();
    }
}
