using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HoverText : MonoBehaviour
{
    public GameObject HoverImage;

    [SerializeField] private Texture2D cursorTexture;
    //[SerializeField] private Texture2D cursorOldTexture;

    public CursorMode cursorMode = CursorMode.Auto;

    private Vector2 cursorHotspot;

    private void Start()
    {
        HoverImage.SetActive(false);
    }

    private void OnMouseEnter()
    {
        HoverImage.SetActive(true);
        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }

    private void OnMouseExit()
    {
        HoverImage.SetActive(false);

        Cursor.SetCursor(null, Vector2.zero, cursorMode);
    }
   
}
