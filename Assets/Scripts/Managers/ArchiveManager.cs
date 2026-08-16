using System.Collections.Generic;
using UnityEngine;

public class ArchiveManager : MonoBehaviour
{
    public static ArchiveManager Instance;

    public List<ArchiveData> archives = new();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        archives.Add(new ArchiveData()
        {
            id="rumor001",
            title="첫 번째 소문",
            description="학생들이 밤마다 이상한 소리를 들었다.",
            unlocked=true
        });

        archives.Add(new ArchiveData()
        {
            id="rumor002",
            title="두 번째 소문",
            description="도서관 지하에 숨겨진 방.",
            unlocked=false
        });
    }
}