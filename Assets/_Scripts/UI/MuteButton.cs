using UnityEngine;
using UnityEngine.UI;

public class MuteButton : MonoBehaviour
{
    [SerializeField] private Button _muteButton;
    
    void Start()
    {
        _muteButton.onClick.AddListener(Manager.Instance.MuteAllSounds);
    }
    
}
