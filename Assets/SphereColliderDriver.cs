using UnityEngine;

public class SphereColliderDriver : MonoBehaviour {
    private CapsuleCollider collider;
    private CharacterController chController;

    private void Start() {
        collider = GetComponent<CapsuleCollider>();
        chController = GetComponent<CharacterController>();
    }

    private void Update() {
        collider.height = chController.height;
        collider.center = chController.center;
    }
}