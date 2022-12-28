using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyButton : MonoBehaviour
{
    [SerializeField] private Button _lobbyButton;
        
    void Start()
    {
        _lobbyButton.onClick.AddListener(LoadLobby);           
    }

    private void LoadLobby()
    {
        SceneManager.LoadScene(0);
    }
}
