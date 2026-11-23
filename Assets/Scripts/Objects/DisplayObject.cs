using UnityEngine;

namespace Objects
{
    public class DisplayObject : DynamicObject
    {
        
        [SerializeField] private InteractiveObject shower;
        [SerializeField] private InteractiveObject hider;

        [SerializeField] private bool isHiddenInitially;
        
        protected override void onInit()
        {
            shower.addClickEvent((_,_)=>show());
            hider.addClickEvent((_,_)=>hide());
            
            gameObject.SetActive(!isHiddenInitially);
        }

        protected void show()
        {
            gameObject.SetActive(true);
        }

        protected void hide()
        {
            gameObject.SetActive(false);
        }
    }
}