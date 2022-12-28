using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private Button _startButton;
    
    void Start()
    {
        _startButton = GetComponent<Button>();
        _startButton.onClick.AddListener(Starting);        
    }
    private void Starting()
    {
        SceneManager.LoadScene(1);
    }
}
