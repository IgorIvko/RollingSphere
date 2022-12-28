using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _followingObject;
    private Vector3 _distance;

    private void Start()
    {
        _distance = transform.position - _followingObject.position;
    }

    private void Update()
    {
        //GetComponent<Rigidbody>().velocity = _followingObject.GetComponent<Rigidbody>().velocity;  
        transform.position = _followingObject.position + _distance;
    }
   
}
