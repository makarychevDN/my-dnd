using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JournalPanel : BaseSynchronizer
{
    [SerializeField] private TMP_Text journalLabel;

    protected override void Synchronize()
    {
        journalLabel.text = Journal.Instance.Data;
    }
}
