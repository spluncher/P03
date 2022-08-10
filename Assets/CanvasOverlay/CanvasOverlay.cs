using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasOverlay : MonoBehaviour
{
    public Texture[] textures;
    private RawImage image;
    public enum OverlayEffect
    {
        Dark,
        Gray,
        Light,
        CracksLight,
        CracksDark,
        Bubbles,
        None
    }

    public OverlayEffect overlayEffect;
    private OverlayEffect lastEffect;
    void Start()
    {
        image = GetComponent<RawImage>();
    }
    void Update()
    {
        image.enabled = overlayEffect != OverlayEffect.None;
        switch (overlayEffect)
        {
            case OverlayEffect.Dark:
                image.texture = textures[0];
                break;
            case OverlayEffect.Gray:
                image.texture = textures[1];
                break;
            case OverlayEffect.Light:
                image.texture = textures[2];
                break;
            case OverlayEffect.CracksLight:
                image.texture = textures[3];
                break;
            case OverlayEffect.CracksDark:
                image.texture = textures[4];
                break;
            case OverlayEffect.Bubbles:
                image.texture = textures[5];
                break;
            default:
                break;
        }
    }

    public void SetOverlayEffect(OverlayEffect effect)
    {
        lastEffect = overlayEffect;
        overlayEffect = effect;
        
    }
    public void SetOverlayEffect(int effect)
    {
        lastEffect = overlayEffect;
        overlayEffect = (OverlayEffect)effect;
    }
    public void DisableOverlayEffect()
    {
        lastEffect = overlayEffect;
        overlayEffect = OverlayEffect.None;
    }

    public void ToggleOverlayEffect(){
        if(overlayEffect == OverlayEffect.None){
            overlayEffect = lastEffect;
        } else {
            lastEffect = overlayEffect;
            overlayEffect = OverlayEffect.None;
        }
    }
}
