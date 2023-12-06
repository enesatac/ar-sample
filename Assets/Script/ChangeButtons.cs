using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeButtons : MonoBehaviour
{
    [SerializeField] private TMP_Text title;
    [SerializeField] private GameObject cube;
    public Renderer cubeRenderer;

    public string[] words = { "XA", "XB", "XC" };

    void Start() {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    public void OnButtonClick() {
        title.text = Random.Range(0, 100).ToString();
    }

    public void ChangeColor() {
        cubeRenderer.material.color = Random.ColorHSV();
    }
}
