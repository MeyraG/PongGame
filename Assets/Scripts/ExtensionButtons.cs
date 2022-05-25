using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExtensionButtons : MonoBehaviour
{
    [SerializeField]
    private Button rotateButton;

    private Extras extras;

    private void Awake()
    {
        extras = FindObjectOfType<Extras>();
    }


    private void Start()
    {
        rotateButton.onClick.AddListener(extras.Rotate);
    }

    private void OnDisable()
    {
        rotateButton.onClick.RemoveListener(extras.Rotate);
    }

}
