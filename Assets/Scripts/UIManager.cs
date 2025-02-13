using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI totalText;

    private int totalboxes = 0;

    public void BoxCollected()
    {
        totalboxes++;
        totalText.text=("Boxes Collected - "+totalboxes);
    }
}
