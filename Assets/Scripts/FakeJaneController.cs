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
