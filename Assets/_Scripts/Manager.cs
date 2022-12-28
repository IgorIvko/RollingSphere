using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    public TextMeshProUGUI starsCountText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI finishDistanceText;
    [SerializeField] private GameObject _sphere;
    [SerializeField] private GameObject _finish;
    [SerializeField] private GameObject _canvasWinLevel;
    [SerializeField] private GameObject _canvasLoseLevel;
    [SerializeField] private Camera _camera2;
    [SerializeField] private int _health;
    [SerializeField] private AudioSource _starSound;
    [SerializeField] private GameObject _sounds;
    private int _starsCount = 0;
    private double _finishDistance;
    private AudioSource _audioController;
    public GameObject Finish => _finish;
    public int Health => _health;
    public GameObject Sphere => _sphere;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        healthText.text = _health.ToString();
    }

    public void EndLevel()
    {
        Time.timeScale = 0;
        _camera2.depth = 1;
        _canvasWinLevel.SetActive(true);    
    }

    public void LoseLevel()
    {
        Time.timeScale = 0;
        _camera2.depth = 1;
        _canvasLoseLevel.SetActive(true);
    }

    public void ReloadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void AddCountStars(int count)
    {
        _starsCount += count;
        starsCountText.text = _starsCount.ToString();
    }

    public void SetFinishDistance(double distance) => _finishDistance = distance;

    private void Update()
    {
        finishDistanceText.text = _finishDistance.ToString() + " m.";
    }

    public void PlayStarSound()
    {
        _starSound.Play();
    }

    public void AddHealth(int count)
    {
        _health += count;
        healthText.text = _health.ToString();
    }

    public void MuteAllSounds()
    {
        foreach (Transform item in _sounds.GetComponentsInChildren<Transform>())
        {
            if (item.TryGetComponent<AudioSource>(out _audioController))
            {
                if (_audioController.mute == false)
                    _audioController.mute = true;
                else
                    _audioController.mute = false;
            }
        }
    }

    public void PauseSphereMoving()
    {
        MoverAxel moverAxel = _sphere.GetComponent<MoverAxel>();
        if (moverAxel.isActiveAndEnabled) moverAxel.enabled = false;
        else moverAxel.enabled = true;
    }    

}
