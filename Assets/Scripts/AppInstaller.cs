using UnityEngine;
using Zenject;

public class AppInstaller : MonoInstaller<AppInstaller>
{
    [SerializeField] GameObject mainWindowPrefab;


    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Hello World!");
        Container.Bind<MainWindow>().AsSingle().NonLazy();

        Container.InstantiatePrefab(mainWindowPrefab);
       
    }
}
