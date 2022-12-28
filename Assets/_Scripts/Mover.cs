using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _level;
    [SerializeField] private Transform _camera;
    private Vector3 _movement;
    private Rigidbody _rigidbody;
    private Vector3 _startPosition;
    private float _moveRotate;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _startPosition = transform.position;
    }
    
    private void Update()
    {
        _moveRotate = Input.GetAxis("Horizontal");
        _level.RotateAround(transform.position, Vector3.up, _moveRotate * Time.deltaTime * _speed);
        //_level.rotation = Quaternion.Euler(new Vector3(0f, _level.rotation.eulerAngles.y + _moveRotate * Time.deltaTime * _speed, 0f));         
        //_camera.rotation = Quaternion.Euler(new Vector3(_camera.rotation.eulerAngles.x, 90f+_level.rotation.eulerAngles.y, _camera.rotation.eulerAngles.z));

        _movement = new Vector3(Input.GetAxis("Vertical"), 0f, 0f);
        _rigidbody.AddForce(_movement * _speed);
        if(transform.position.y < 40f)
        {
            transform.position = _startPosition;
            _rigidbody.velocity = Vector3.zero;
        }

        //_rigidbody.velocity = _movement * _speed;

    }


}
