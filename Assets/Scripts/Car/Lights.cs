using UnityEngine;

namespace Car
{
    public class Lights : MonoBehaviour
    {
        [SerializeField]
        private GameObject tailLights;    
        [SerializeField]
        private Material brakeMaterial;
        [Space]
        [SerializeField]
        private GameObject frontLights;
        [SerializeField]
        private Material frontMaterial;

        
        public void ReversLights(float value)
        {
            if (value > 0)
            {
                frontLights.SetActive(true);
                frontMaterial.EnableKeyword("_EMISSION");
            }
            else
            {
                frontLights.SetActive(false);
                frontMaterial.DisableKeyword("_EMISSION");
                if (value < 0)
                {                
                    tailLights.SetActive(true);           
                    brakeMaterial.EnableKeyword("_EMISSION");
                }
                else
                {
                    tailLights.SetActive(false);               
                    brakeMaterial.DisableKeyword("_EMISSION");
                }    
            } 
        }
        
        public void FrontLights(bool on)
        {
            frontLights.SetActive(on);
            if (on)
            {
                frontMaterial.EnableKeyword("_EMISSION");
            }
            else
            {
                frontMaterial.DisableKeyword("_EMISSION");
            }
        }
        
        public void TailLights(bool on)
        {
            tailLights.SetActive(on);
            if (on)
            {
                brakeMaterial.EnableKeyword("_EMISSION");
            }
            else
            {
                brakeMaterial.DisableKeyword("_EMISSION");
            }
        }
    }
}