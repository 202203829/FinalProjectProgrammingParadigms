using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    public float laneDistance = -3.5f;  // Distancia entre carriles
    public float transitionSpeed = 15f; // Velocidad de transición entre carriles

    public float jumpHeight = 3f;     // Altura del salto
    public float jumpSpeed = 2f;      // Velocidad de salto

    private int currentLane = 1;  // Índice de carril (0 = izquierda, 1 = centro, 2 = derecha)

    public ColliderManager colliderManager;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();  // Obtener el componente Animator
        animator.SetBool("isRunning", true);  // Activar animación de correr (aunque no se moverá)
        colliderManager.SetColliderState("normal");
    }

    void Update()
    {
        // Cambiar de carril con la flecha izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow) && currentLane > 0)
        {
            currentLane--;
        }

        // Cambiar de carril con la flecha derecha
        if (Input.GetKeyDown(KeyCode.RightArrow) && currentLane < 2)
        {
            currentLane++;
        }

        // Calcular la posición objetivo en el eje Z según el carril actual
        float targetx = (currentLane - 1) * laneDistance;

        // Moverse suavemente hacia la posición objetivo en el eje Z
        float newx = Mathf.Lerp(transform.position.x, targetx, transitionSpeed * Time.deltaTime);
        transform.position = new Vector3(newx, transform.position.y, transform.position.z);

        // Ejecutar animación de salto si se presiona la tecla UpArrow
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("JumpSpinAround");  // Activar animación de salto
            colliderManager.SetColliderState("jump");
        }

        // Ejecutar animación de deslizamiento (slide) si se presiona la tecla DownArrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("Slide");  // Activar animación de deslizamiento
            colliderManager.SetColliderState("slide");

        }
    }
}
