using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();  // Obtiene el componente Animator del objeto
        animator.SetBool("isRunning", true);  // Activa la animaci�n de correr autom�ticamente
    }

    void Update()
    {
        // Detecta la tecla para saltar
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("JumpSpinAround");  // Activa la animaci�n de salto
        }

        // Detecta la tecla para deslizarse
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Slide");  // Activa la animaci�n de deslizar
        }

        // Detecta la tecla para la animaci�n de victoria
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("WinnerDance");  // Activa la animaci�n de victoria
        }
    }
}
