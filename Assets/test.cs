using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Async;
using System.Threading.Tasks;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private InputField inputField;
    [SerializeField] private Text countText;
    [SerializeField] private Text greetText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    async UniTask<string> func()
    {

        return await Task.Run(() => "Hello!");


    }
}
