using UnityEngine;

public class ColliderManager : MonoBehaviour
{
    // Referencias a los colliders de cada acci�n
    public CapsuleCollider normalCollider; 
    public CapsuleCollider jumpCollider;
    public CapsuleCollider slideCollider; 

    // M�todo para activar un collider espec�fico y desactivar los dem�s
    public void SetColliderState(string state)
    {
        // Desactiva todos los colliders primero
        normalCollider.enabled = false;
        jumpCollider.enabled = false;
        slideCollider.enabled = false;

        // Activa el collider correspondiente seg�n el estado
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

