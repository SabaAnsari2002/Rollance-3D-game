using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;
    [SerializeField] private Color[] colors;
    private int colorIndex = 0;
    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;
    void Update(){
        SetColorChangeTime();
        SetGroundMaterialSmothColorChange();
    }
    private void SetColorChangeTime(){
        if (currentTime <= 0){
            CheckColorIndexValue();
            currentTime = time;
        }
        else{
            currentTime -= Time.deltaTime;
        }
    }
    private void CheckColorIndexValue(){
        colorIndex++;
        if (colorIndex >= colors.Length){
            colorIndex = 0;
        }
    }
    private void SetGroundMaterialSmothColorChange(){
        groundMaterial.color = Color.Lerp(groundMaterial.color,colors[colorIndex],lerpValue*Time.deltaTime);
    }
}
