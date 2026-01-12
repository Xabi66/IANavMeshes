# Descrición

Escena *FollowPlayer* na que o xogador movese por ela mentres é perseguido por un grupo de chompers e unha versión deformada da sua personaxe denominada **FakeJane**.

O Chomper grande non pode acceder á area mask Rock, os chompers pequenos non poden acceder á area mask BigChompersRock e FakeJane non pode acceder á area mask Torre

# Título principal

**Area Mask Torre**

## Subtítulo

Lista de cambios:

- Engadida unha torre á escena *FollowPlayer* contruida empregando cubos e o material *Rock02Grey*.
- Engadida unha nova area mask chamada Torre e asignada á torre construida na escena
- Engadido un novo NPC chamado **FakeJane** e creado empregando o modelo do xogador, deformandoo e asignandolle compoñentes similares aos dos chompers.
- Engadido un novo script *FakeJaneController* a partir do script *AIController.cs*

[Ligazón](https://exemplo.com)


```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FakeJaneController : MonoBehaviour { // Clase que controla o comportamento básico da IA

    public NavMeshAgent agent; // Referencia ao compoñente NavMeshAgent para a navegación
    public GameObject target; // Obxecto obxectivo ao que se dirixe a IA
    Animator anim; // Referencia ao compoñente Animator para as animacións

    void Start() { // Inicialízase ao comezar

        agent = GetComponent<NavMeshAgent>(); // Obtén o compoñente NavMeshAgent
        anim = GetComponent<Animator>(); // Obtén o compoñente Animator
    }

    void Update() { // Actualízase en cada frame

        agent.SetDestination(target.transform.position); // Establece o destino ao obxectivo
    }
}


```