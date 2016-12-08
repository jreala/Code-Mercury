using UnityEngine;

public class UpdateUIButtons : MonoBehaviour
{
    public GameObject SwitchFrom;
    public GameObject SwitchTo;

    public void Switch()
    {
        SwitchFrom.SetActive(false);
        SwitchTo.SetActive(true);
    }
}
