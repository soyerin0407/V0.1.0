using System.Collections.Generic;
using UnityEngine;

public class MailManager : MonoBehaviour
{
    public static MailManager Instance;

    public List<MailData> mails = new();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        mails.Add(new MailData()
        {
            sender="관리국",
            title="상담 신청이 접수되었습니다.",
            content="오늘도 수고하셨습니다."
        });
    }
}