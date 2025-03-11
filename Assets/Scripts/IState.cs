// Interface que define os métodos que todos os estados devem implementar
public interface IState
{
    // Método chamado quando o estado é ativado ou iniciado
    void OnEnter();

    // Método chamado a cada frame durante o estado, que retorna o próximo estado
    StateMachine.EState OnUpdate();

    // Método chamado quando o estado é desativado ou terminado
    void OnExit();
}
