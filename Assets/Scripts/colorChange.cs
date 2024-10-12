using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorChange : MonoBehaviour
{
    public GameObject modelo;
    public Button bColor;

    private Color[] colors = new Color[5]{
        new Color(0.8f, 0.3f, 0.3f),  
        new Color(0.3f, 0.8f, 0.4f), 
        new Color(0.2f, 0.4f, 0.9f),  
        new Color(0.9f, 0.8f, 0.1f),  
        new Color(0.4f, 0.2f, 0.6f)   
    };
    private Color colorOrig;
    private int colorIndex = 0;
    private Material materialModel;

    // Start is called before the first frame update
    void Start()
    {
        materialModel = modelo.GetComponent<Renderer>().material;
        colorOrig = materialModel.color;
        bColor.onClick.AddListener(ChangeColor);
    }

    void ChangeColor()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
            materialModel.color = colorOrig;
        }
        else{
            materialModel.color = colors[colorIndex];
            colorIndex++;
        }
        
    }
}
