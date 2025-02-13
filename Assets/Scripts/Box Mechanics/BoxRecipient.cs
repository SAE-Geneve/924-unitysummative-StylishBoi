using UnityEngine;

public class BoxRecipient : MonoBehaviour
{
    [SerializeField] UIManager uIManager;
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Box"))
        {
            Destroy(collision);
            uIManager.BoxCollected();
        }
    }
}
