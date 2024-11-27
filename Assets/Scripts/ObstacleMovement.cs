using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Velocidad de movimiento de los obst�culos
    public float speed = 2f;

    // Update is called once per frame
    void Update()
    {
        // Mover el obst�culo hacia el jugador a lo largo del eje Z
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
