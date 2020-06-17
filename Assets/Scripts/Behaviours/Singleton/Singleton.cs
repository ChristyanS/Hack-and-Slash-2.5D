using UnityEngine;

namespace Behaviours.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = FindObjectOfType<T>();
                if (_instance == null)
                    Debug.LogError("Singleton<" + typeof(T) + "> instance has been not found.");
                return _instance;
            }
        }

        protected void Awake()
        {
            if (GetType() != typeof(T))
                DestroySelf();
            if (_instance == null)
                _instance = this as T;
            else if (_instance != this)
                DestroySelf();
            DontDestroyOnLoad(gameObject);
        }

//todo isto daqui é uma otima validação porem deve haver uma correção pois ele mantem o estado do prefab apos o encerramento do jogo então ate descobrir como usar de uma maneira melhor deixar isso aqui
//        protected void OnValidate()
//        {
//            if (this.GetType() != typeof(T)) //Change to solve the problem
//            {
//                Debug.LogError("Singleton<" + typeof(T) + "> has a wrong Type Parameter. " +
//                               "Try Singleton<" + GetType() + "> instead.");
//#if UNITY_EDITOR
//                UnityEditor.EditorApplication.delayCall -= DestroySelf;
//                UnityEditor.EditorApplication.delayCall += DestroySelf;
//#endif
//            }
//
//            if (instance == null)
//                instance = this as T;
//            else if (instance != this)
//            {
//                Debug.LogError("Singleton<" + GetType() +
//                               "> already has an instance on scene. Component will be destroyed.");
//#if UNITY_EDITOR
//                UnityEditor.EditorApplication.delayCall -= DestroySelf;
//                UnityEditor.EditorApplication.delayCall += DestroySelf;
//#endif
//            }
//        }
//
//
        private void DestroySelf()
        {
            if (Application.isPlaying)
                Destroy(this);
            else
            {
                DestroyImmediate(this);
            }
        }
    }
}