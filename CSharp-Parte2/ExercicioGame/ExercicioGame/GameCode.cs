public class GameRPGTeste
{
    public string nomePersonagem;
    public string sexo;
    public string classeRPG;
    public bool armaUsada;

    public bool guerreiro(bool estilo)
    {
        if (this.armaUsada == true)
        {
            return true;
        }
        else
        {
            this.armaUsada = false;
            return false;
        }
    }
}