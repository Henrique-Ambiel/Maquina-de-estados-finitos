using UnityEngine;

// Classe que implementa o estado de perseguição (Chase), seguindo a interface IState
public class Chase : IState
{
    // Construtor da classe Chase. Recebe um Rigidbody e um array de pontos de patrulha (waypoints).
    // Esses parâmetros não são usados diretamente, mas podem ser necessários para controlar o movimento do agente.
    public Chase(Rigidbody rigidbody, Vector3[] wayPoints) { }

    // Método chamado quando o estado de perseguição é ativado
    public void OnEnter()
    {
        // Aqui você pode adicionar lógica para inicializar o estado de perseguição,
        // como configurar o agente para começar a perseguir um alvo ou tocar uma animação de perseguição.
    }

    // Método chamado quando o estado de perseguição é desativado ou trocado
    public void OnExit()
    {
        // Aqui você pode adicionar lógica para finalizar o estado de perseguição,
        // como parar a animação ou limpar recursos relacionados ao estado de perseguição.
    }

    // Método chamado a cada frame enquanto o estado de perseguição está ativo.
    // Ele retorna o próximo estado que a máquina de estados deve mudar para.
    public StateMachine.EState OnUpdate()
    {
        // Neste exemplo, o agente permanece no estado de perseguição e não muda para outro estado.
        // Esse método poderia, por exemplo, verificar se o agente alcançou o alvo e, então, mudar para outro estado,
        // mas por enquanto, ele sempre retorna o estado de perseguição.
        return StateMachine.EState.Chase;
    }
}
