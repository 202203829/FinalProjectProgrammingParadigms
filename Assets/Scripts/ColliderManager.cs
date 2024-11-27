using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    // Referencias a los colliders de cada acción
    public CapsuleCollider normalCollider; 
    public CapsuleCollider jumpCollider;
    public CapsuleCollider slideCollider; 

    // Método para activar un collider específico y desactivar los demás
    public void SetColliderState(string state)
    {
        // Desactiva todos los colliders primero
        normalCollider.enabled = false;
        jumpCollider.enabled = false;
        slideCollider.enabled = false;

        // Activa el collider correspondiente según el estado
        switch (state)
        {
            case "normal":
                normalCollider.enabled = true;
                Debug.Log("normal collider activo");

                break;
            case "jump":
                jumpCollider.enabled = true;
                Debug.Log("Jump collider activo");

                break;
            case "slide":
                slideCollider.enabled = true;
                Debug.Log("slider collider activo");

                break;
            default:
                break;
        }
    }
}

