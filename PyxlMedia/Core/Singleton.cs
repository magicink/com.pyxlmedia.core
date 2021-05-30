using UnityEngine;

namespace PyxlMedia.Core
{
    public abstract class Singleton<T> : MonoBehaviour where T: Singleton<T>
    {
        private static T _instance;
        public T Instance { get => _instance; }

        protected virtual void Awake()
        {
            if (_instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                _instance = (T) this;
            }
        }

        protected void OnDestroy()
        {
            if (_instance == this)
            {
                _instance = null;
            }
        }
    }
}
