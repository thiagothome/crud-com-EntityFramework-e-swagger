namespace AwesomeDevEvents.Api.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string TalkTitle { get; set; }
        public string TalkTitleDescription { get; set; }
        public string LinkedinProfile { get; set; }
        public Guid DevEventId { get; set; }
    }
}

/*
 namespace AwesomeDevEvents.Api.Entities
{
    public class DevEventSpeaker
    {

        // id nome titulo descricao e perfilLinkedin
        public Guid Id{ get; set; }
        public string Formacao{ get; set; }
        public string PerfilLinkedin{ get; set; }
    }
}
 */