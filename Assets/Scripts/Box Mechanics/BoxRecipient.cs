using UnityEngine;

public class BoxRecipient : MonoBehaviour
{
    [SerializeField] UIManager uIManager;
    
    void OnTriggerEnter(Collider collision)
    {
        //When the detector detects a box, it destroy it and updated the score
        if (collision.CompareTag("Box"))
        {
            Destroy(collision);
            uIManager.BoxCollected();
        }
    }
}
