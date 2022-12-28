using UnityEngine;

public class Star : MonoBehaviour
{    
    private MoverAxel _mover;    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<MoverAxel>(out _mover))
        {            
            Manager.Instance.AddCountStars(1);
            Manager.Instance.PlayStarSound();
            gameObject.SetActive(false);
        }
    }
}
