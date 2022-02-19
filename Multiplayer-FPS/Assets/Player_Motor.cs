using UnityEngine;


 [RequireComponent(typeof(Rigidbody))]
public class Player_Motor : MonoBehaviour
{
    Vector3 _velocity = Vector3.zero;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


}
