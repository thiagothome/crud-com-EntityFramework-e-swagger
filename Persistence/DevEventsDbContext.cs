using AwesomeDevEvents.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace AwesomeDevEvents.Api.Persistence
{
    public class DevEventsDbContext : DbContext
    {

        public DevEventsDbContext(DbContextOptions<DevEventsDbContext> options) : base(options)
        {
        }
        public DbSet<DevEvent> DevEvents { get; set; }
        public DbSet<DevEventSpeaker> DevEventSpeakers { get; set; }


        /*
            O método OnModelCreating é parte do processo de configuração do Entity Framework Core para mapear classes de modelo (entidades) para tabelas no banco de dados. Ele é chamado quando o contexto do banco de dados é inicializado e é usado para definir o modelo de dados e configurar o mapeamento entre as entidades e as tabelas do banco de dados. 
        */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DevEvent>(e =>
            {
                // Aqui você pode configurar o mapeamento entre a entidade DevEvent
                // e a tabela correspondente no banco de dados.
                // Isso pode incluir configurações como chaves primárias, chaves estrangeiras,
                // nomes de colunas, restrições de integridade etc.

                e.HasKey(e => e.Id); //O e => e.Id é uma expressão lambda que especifica qual propriedade da entidade será usada como chave primária. 
                e.Property(de => de.Title).IsRequired(false);
                e.Property(de => de.Description).HasMaxLength(200).HasColumnType("varchar(200)");
                e.Property(de => de.StartDate).HasColumnName("Start_Date");
                e.Property(de => de.StartDate).HasColumnName("End_Date");
                e.HasMany(de => de.Speakers).WithOne().HasForeignKey(s => s.DevEventId); //.WithOne(): Indica que a entidade Speaker tem apenas um evento associado a ela.
            });

            builder.Entity<DevEventSpeaker>(e =>
            {
                e.HasKey(e=>e.Id);
            });
        }
    }
}
