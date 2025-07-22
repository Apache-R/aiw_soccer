using UnityEngine;

public class Skinloader : MonoBehaviour
{
    public GameObject[] skinPrefabs;  
    public Transform modelHolder;    

    void Start()
    {
        int index = PlayerPrefs.GetInt("SelectedSkin", 0);

        foreach (Transform child in modelHolder)
            Destroy(child.gameObject);

        GameObject skin = Instantiate(skinPrefabs[index], modelHolder);
        skin.transform.localPosition = Vector3.zero;
        skin.transform.localRotation = Quaternion.identity;
    }
}
