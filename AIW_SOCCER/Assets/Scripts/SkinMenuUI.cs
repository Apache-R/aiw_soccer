using UnityEngine;

public class SkinMenuUI : MonoBehaviour
{
    public GameObject skinPanel;
    public void OpenSkinPanel()
    {
        skinPanel.SetActive(true);
    }
    public void CloseSkinPanel()
    {
        skinPanel.SetActive(false);
    }
    
}
