using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();  // Obtiene el componente Animator del objeto
        animator.SetBool("isRunning", true);  // Activa la animación de correr automáticamente
    }

    void Update()
    {
        // Detecta la tecla para saltar
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("JumpSpinAround");  // Activa la animación de salto
        }

        // Detecta la tecla para deslizarse
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Slide");  // Activa la animación de deslizar
        }

        // Detecta la tecla para la animación de victoria
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("WinnerDance");  // Activa la animación de victoria
        }
    }
}
