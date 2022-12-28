using UnityEngine;

public class SoundSphereCollision : MonoBehaviour
{
    [SerializeField] AudioSource _collisionSound;
    private const float minVolume = 0f;
    private const float maxVolume = 0.75f;
    private const float minVelocity = 0.5f;
    private const float maxVelocity = 20f;
    private MoverAxel _mover;

    private void OnCollisionEnter(Collision collision)
    {        
        if(collision.gameObject.TryGetComponent<MoverAxel>(out _mover))
        {            
            if (Mathf.Abs(_mover.VelocityZ) > minVelocity)
            {
                _collisionSound.Play();                
            }
        }   
    }

    private void OnCollisionExit(Collision collision)
    {        
        if (collision.gameObject.TryGetComponent<MoverAxel>(out _mover))
        {            
            _collisionSound.Pause();            
        }
    }

    private void Update()
    {
        if (_collisionSound.isPlaying && _mover != null)
        {
            _collisionSound.volume = Mathf.Lerp(minVolume, maxVolume, Mathf.Abs(_mover.VelocityZ) / maxVelocity);            
        }
    }

}
