using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    private Button _pauseButton;
    void Start()
    {
        _pauseButton = GetComponent<Button>();
        _pauseButton.onClick.AddListener(MakePause);
    }

   private void MakePause()
    {
        if(Time.timeScale == 1f)
        {
            Time.timeScale = 0f;
            _pausePanel.SetActive(true);
        }
        else if (Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            _pausePanel.SetActive(false);
        }

        Manager.Instance.PauseSphereMoving();
        Manager.Instance.MuteAllSounds();
    }
}
