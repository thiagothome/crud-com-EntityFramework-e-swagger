namespace AwesomeDevEvents.Api.Entities
{
    public class DevEvent
    {
        public DevEvent()
        {
            Speakers = new List<DevEventSpeaker>();
            IsDeleted = false;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }

        public void Update(string title, string description, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;

        }

        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
/*
 namespace AwesomeDevEvents.Api.Entities
{
    public class DevEvent
    {

        //construtor com bool false e lista de palestrante vazia
        //id titulo descricao dataInicio dataFim deletado lista de palestrante 
        // metodo atualizar  atualizando as props e metodo delete configurando bool pra true

        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool estaRemovido{ get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }

        public void Atualizar(string titulo, string descricao, DateTime dataInicio, DateTime dataFim)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataInicio = dataInicio;
            DataFim = dataFim;

        }

        public void Remover()
        {
            estaRemovido = true;
        }

    }
}

 */