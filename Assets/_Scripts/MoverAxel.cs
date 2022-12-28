using System;
using UnityEngine;

public class MoverAxel : MonoBehaviour
{
    public static float speed = 32f;
    public static float speedY = 50f;
    [SerializeField] private float _accelerationWeight = 25f;
    [SerializeField] Transform _level;
    [SerializeField] Transform _startPlatform;
    private Vector3 _movement;
    private Rigidbody _rigidbody;
    private Vector3 _startPosition;
    private const float _maxForce = 10f;
    private const float _maxAngle = 50f;
    private const float _maxVelocity = 20f;
    private float _velocityZ;
    private float _forceX = 0f;
    private float _forceY = 0f;
    public float VelocityZ => _velocityZ;    

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _startPosition = _startPlatform.position + new Vector3(0f, 1.1f, 0f);
    }

    private void Update()
    {
        //_forceX = Mathf.Clamp(Input.acceleration.y * speed + _accelerationWeight, -_maxForce, _maxForce);
        _forceX = -Mathf.Clamp(Input.acceleration.z * speed, -_maxForce, _maxForce);
        _forceY = -Mathf.Clamp(Input.acceleration.x * speedY, -_maxAngle, _maxAngle);        
        _rigidbody.velocity = new Vector3(Mathf.Clamp(_rigidbody.velocity.x, -_maxVelocity, _maxVelocity), Mathf.Clamp(_rigidbody.velocity.y, -_maxVelocity, _maxVelocity), Mathf.Clamp(_rigidbody.velocity.z, -_maxVelocity, _maxVelocity));
        _velocityZ = _rigidbody.velocity.z;
        _movement = new Vector3(_forceX, 0f, 0f);        
        _rigidbody.AddForce(_movement);
        _level.RotateAround(transform.position, Vector3.up, _forceY * Time.deltaTime);

        Manager.Instance.SetFinishDistance(Math.Round(Vector3.Distance(transform.position, Manager.Instance.Finish.transform.position),3));
        
        if (transform.position.y < 40f)
        {
            Manager.Instance.AddHealth(-1);
            if(Manager.Instance.Health <= 0)
            {
                Manager.Instance.LoseLevel();
            }
            transform.position = _startPosition;
            _rigidbody.velocity = Vector3.zero;
        }
    }
}
