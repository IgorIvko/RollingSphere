using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Testing : MonoBehaviour
{
    private Button _testingButton;

    void Start()
    {
        _testingButton = GetComponent<Button>();
        _testingButton.onClick.AddListener(Starting);
    }
    private void Starting()
    {
        SceneManager.LoadScene(2);
    }
}

