//simple top-down follow player camera script
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    
    //for the object above player
    public Transform newcampos;
    
    //update function
    void Update() {
    //binding camera above player
    transform.position = newcampos.transform.position;
    }
}
