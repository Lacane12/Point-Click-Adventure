using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArtifactController : MonoBehaviour
{
    public int Count = 0;
    public int Number = 1;
    public GameObject Icon;
    public TextMeshProUGUI textMesh;

    public bool isAllowed = false;  

    public static ArtifactController Instance;

    private void Start()
    {
        Instance = this;
    }

    public void ShowIcon()
    {
        Icon.SetActive(true);
    }
    public void AddCount(int number)
    {
        Count += number;
        UpdateText();
    }

    void UpdateText()
    {
        textMesh.text = Count.ToString() + "/" + Number.ToString();
    }
}
