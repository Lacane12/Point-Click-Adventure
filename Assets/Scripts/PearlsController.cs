using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PearlsController : MonoBehaviour
{
    public int PearlsCount = 0;
    public int Number = 6;
    public GameObject Icon;
    public TextMeshProUGUI textMesh;


    public bool isAllowed = false;

    public static PearlsController Instance;

    private void Start()
    {
        Instance = this;
    }

    public void ShowIcon() {
        Icon.SetActive(true);
    }
    public void AddPearls(int number) {
        PearlsCount += number;
        UpdateText();
    }

    void UpdateText() { 
        textMesh.text = PearlsCount.ToString() + "/" + Number.ToString();
    }
}
