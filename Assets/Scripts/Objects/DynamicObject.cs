using UnityEngine;

namespace Objects
{
    public abstract class DynamicObject : MonoBehaviour
    {
        protected Stage stage;
        protected View view;

        public void Init(Stage stage,View view)
        {
            this.stage = stage;
            this.view = view;
            
            onInit();
        }

        protected abstract void onInit();
    }
}