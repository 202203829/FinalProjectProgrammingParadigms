using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public Animator playerAnimator; // Referencia al Animator del jugador

    // Este método se llama cuando el jugador colisiona con otro objeto
    void OnCollisionEnter(Collision collision)
    {
        // Ignorar colisión si el objeto tiene la etiqueta "Ground"
        if (collision.gameObject.CompareTag("Ground"))
        {
            return;
        }

        // Verifica si el objeto con el que colisiona tiene un Rigidbody
        if (collision.gameObject.GetComponent<Rigidbody>() != null)
        {
            // Iniciar la corutina para esperar 1 segundo antes de cambiar de escena
            SceneManager.LoadScene("GameOver");
        }
    }
}
