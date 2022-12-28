using UnityEngine;

public class SpherePhysics : MonoBehaviour
{    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == Manager.Instance.Finish)
        {
            Manager.Instance.EndLevel();
        }    
    }
   
}
