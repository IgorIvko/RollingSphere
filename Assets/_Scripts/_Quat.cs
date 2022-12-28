using UnityEngine;

public class _Quat : MonoBehaviour
{
    public Quaternion Quat;    
    
    
    void Update()
    {
        Quat = transform.rotation;        
    }
}
