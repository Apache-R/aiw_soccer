using UnityEngine;

public class SkinSelectorForButtons : MonoBehaviour
{
   public void SelectSkin(int skinIndex)
    {
        PlayerPrefs.SetInt("SelectedSkin", skinIndex);
        PlayerPrefs.Save();
        Debug.Log("Skin " + skinIndex + " selected.");
    }
}
