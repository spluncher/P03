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
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
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
            case OverlayEffect.One:
                image.texture = textures[0];
                break;
            case OverlayEffect.Two:
                image.texture = textures[1];
                break;
            case OverlayEffect.Three:
                image.texture = textures[2];
                break;
            case OverlayEffect.Four:
                image.texture = textures[3];
                break;
            case OverlayEffect.Five:
                image.texture = textures[4];
                break;
            case OverlayEffect.Six:
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
