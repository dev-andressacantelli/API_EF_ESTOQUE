namespace pjt.apc.estoque.domain.Results
{
    public class Response
    {
        //public string? Resultado { get; set; } 
        //public string? Erro { get; set; }
        public Resultado Resultado { get; private set; } = new Resultado();
        public Erro Erro { get; private set; } = new Erro();
    }

    public class Resultado
    {
        public object Objeto { get; set; }

        public string Mensagem { get; set; }
    }

    public class Erro
    {
        public string Mensagem { get; set; }
    }
}

// Response.StatusCode = StatusCodes.Status400BadRequest;   