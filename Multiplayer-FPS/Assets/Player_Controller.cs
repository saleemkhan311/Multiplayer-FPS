using UnityEngine;


[RequireComponent(typeof(Player_Motor))]
public class Player_Controller : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Player_Motor motor;
    private void Start()
    {
        motor = GetComponent<Player_Motor>();
    }

    private void Update()
    {
        // Calculate movement velocity as a 3D Vector

        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        Vector3 movHorizpntal = transform.right * xMov;
        Vector3 movVertical = transform.forward * zMov;
        // final movement Vector
        Vector3 velocity = (movHorizpntal + movVertical).normalized *speed ;

        // Apply Movement

        motor.Move(velocity);
    }
}
