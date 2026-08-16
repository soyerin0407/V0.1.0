using TMPro;
using UnityEngine;

public class ArchiveViewer : MonoBehaviour
{
    [SerializeField] TMP_Text title;
    [SerializeField] TMP_Text description;

    public void Show(ArchiveData data)
    {
        title.text = data.title;
        description.text = data.description;
    }
}